using backend.Data;
using backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace backend.Services
{
    // Recalculates MSAN cumulative scheduled and attended values within each half-year cycle.
    public class MsanMtcDataCumulativeService : IMsanMtcDataCumulativeService
    {
        // Converts month names to numbers so source rows can be ordered chronologically.
        private static readonly Dictionary<string, int> MonthSequence =
            CultureInfo.InvariantCulture.DateTimeFormat.MonthNames
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Select((name, index) => new { Name = name, Number = index + 1 })
                .ToDictionary(x => x.Name, x => x.Number, StringComparer.OrdinalIgnoreCase);

        private readonly AppDbContext _db;

        // Uses the shared context to update only the source rows whose cumulative values changed.
        public MsanMtcDataCumulativeService(AppDbContext db)
        {
            _db = db;
        }

        // Rebuilds every valid designation/year group and saves all changes in one batch.
        public async Task<MsanMtcDataBackfillResult> RecalculateAllAsync()
        {
            var records = await _db.MsanMtcData.ToListAsync();
            var groupsProcessed = 0;
            var recordsUpdated = 0;

            var groups = records
                .Where(x => !string.IsNullOrWhiteSpace(x.Designation) && x.Year.HasValue)
                .GroupBy(x => new
                {
                    Designation = x.Designation!.Trim(),
                    Year = x.Year!.Value
                });

            foreach (var group in groups)
            {
                groupsProcessed++;
                recordsUpdated += RecalculateGroup(group);
            }

            if (recordsUpdated > 0)
            {
                await _db.SaveChangesAsync();
            }

            return new MsanMtcDataBackfillResult(records.Count, groupsProcessed, recordsUpdated);
        }

        // Rebuilds one designation for one year, used when a single source group is corrected.
        public async Task<int> RecalculateAsync(string designation, int year)
        {
            var normalizedDesignation = designation.Trim();
            if (string.IsNullOrWhiteSpace(normalizedDesignation)) return 0;

            var records = await _db.MsanMtcData
                .Where(x =>
                    x.Designation != null &&
                    x.Designation.Trim() == normalizedDesignation &&
                    x.Year == year)
                .ToListAsync();

            var recordsUpdated = RecalculateGroup(records);
            if (recordsUpdated > 0)
            {
                await _db.SaveChangesAsync();
            }

            return recordsUpdated;
        }

        // Resets totals at the January/July boundary and writes the running totals through the group.
        private static int RecalculateGroup(IEnumerable<MsanMtcData> records)
        {
            var runningScheduled = 0;
            var runningAttended = 0;
            var recordsUpdated = 0;
            int? currentCycle = null;

            foreach (var record in records.OrderBy(x => GetMonthNumber(x.Month)))
            {
                var monthNumber = GetMonthNumber(record.Month);
                if (monthNumber == 0) continue;

                var cycle = monthNumber <= 6 ? 1 : 2;
                if (currentCycle != cycle || monthNumber == 1 || monthNumber == 7)
                {
                    runningScheduled = 0;
                    runningAttended = 0;
                    currentCycle = cycle;
                }

                runningScheduled += record.Scheduled ?? 0;
                runningAttended += record.Attended ?? 0;

                if (record.CumulativeSched != runningScheduled ||
                    record.CumulativeAchieved != runningAttended)
                {
                    record.CumulativeSched = runningScheduled;
                    record.CumulativeAchieved = runningAttended;
                    recordsUpdated++;
                }
            }

            return recordsUpdated;
        }

        // Invalid or missing month names return zero and are skipped by the cumulative calculation.
        private static int GetMonthNumber(string? month)
        {
            if (string.IsNullOrWhiteSpace(month)) return 0;
            return MonthSequence.TryGetValue(month.Trim(), out var monthNumber) ? monthNumber : 0;
        }
    }
}
