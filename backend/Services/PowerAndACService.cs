using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using backend.Data;
using Microsoft.EntityFrameworkCore;

namespace backend.Services
{
    // Calculates the Power and AC routine-maintenance KPI from quarterly source rows.
    public class PowerAndACService
    {
        private readonly AppDbContext _db;

        // Uses no-tracking reads because this service only derives KPI results from source data.
        public PowerAndACService(AppDbContext db)
        {
            _db = db;
        }

        // Sums scheduled and attended values from the current quarter through the selected month.
        public async Task<List<RoutineMaintenanceResult>> GetPowerAndACPercentagesAsync(
            short year,
            byte month,
            Dictionary<string, string> designationToArea)
        {
            var selectedMonthNum = (int)month;
            var quarter = ((selectedMonthNum - 1) / 3) + 1;
            var startMonth = (quarter - 1) * 3 + 1;

            var rows = await _db.PowerAndAC
                .AsNoTracking()
                .Where(x => x.Year == year)
                .ToListAsync();

            // Keep the source-row diagnostics available while validating imported maintenance data.
            Console.WriteLine($"DEBUG: Retrieved {rows.Count} rows from PowerAndAC table for year {year}");
            foreach (var r in rows)
            {
                Console.WriteLine($"DEBUG ROW: Designation='{r.Designation}', Year={r.Year}, Month={r.Month}, Sched={r.Scheduled}, Attended={r.Attended}");
            }

            var results = new List<RoutineMaintenanceResult>();
            var groups = rows.GroupBy(x => (x.Designation ?? string.Empty).Trim());

            foreach (var group in groups)
            {
                var designation = group.Key;
                if (string.IsNullOrEmpty(designation)) continue;

                // Power and AC does not rely on stored cumulative columns, so totals are derived for this quarter.
                var quarterRows = group
                    .Where(x => x.Month >= startMonth && x.Month <= selectedMonthNum)
                    .ToList();

                if (!quarterRows.Any()) continue;

                var sched = (decimal)quarterRows.Sum(x => x.Scheduled);
                var achieved = (decimal)quarterRows.Sum(x => x.Attended);

                var percent = RoutineMaintenanceServiceHelpers.CalculatePercentage(sched, achieved);

                var areaCode = ResolveAreaCode(designationToArea, designation);
                areaCode ??= string.Empty;

                results.Add(new RoutineMaintenanceResult(designation, areaCode, percent, sched));
            }

            Console.WriteLine($"Power & AC rows = {results.Count}");
            return results;
        }

        // Resolves exact, suffix-stripped, and normalized designation keys to an area code.
        private static string ResolveAreaCode(IReadOnlyDictionary<string, string> designationToArea, string designation)
        {
            if (designationToArea.TryGetValue(designation, out var direct) && !string.IsNullOrWhiteSpace(direct))
            {
                return direct;
            }

            var baseDesignation = StripDesignationSuffix(designation);
            if (baseDesignation != designation
                && designationToArea.TryGetValue(baseDesignation, out var fromBase)
                && !string.IsNullOrWhiteSpace(fromBase))
            {
                return fromBase;
            }

            var normalizedDesignation = NormalizeLookupKey(baseDesignation);
            if (normalizedDesignation != string.Empty
                && designationToArea.TryGetValue(normalizedDesignation, out var fromNormalized)
                && !string.IsNullOrWhiteSpace(fromNormalized))
            {
                return fromNormalized;
            }

            return string.Empty;
        }

        // Removes annotations such as a parenthesized suffix before attempting a mapping.
        private static string StripDesignationSuffix(string value)
        {
            var designation = value?.Trim() ?? string.Empty;
            if (designation == string.Empty) return string.Empty;

            var idx = designation.IndexOf('(');
            return idx >= 0
                ? designation[..idx].Trim()
                : designation;
        }

        // Makes designation comparisons tolerant of spaces, punctuation, and casing differences.
        private static string NormalizeLookupKey(string value)
            => Regex.Replace(value ?? string.Empty, "[^A-Za-z0-9]+", "").ToLowerInvariant();
    }
}
