using backend.Data;
using backend.DTOs;
using Microsoft.EntityFrameworkCore;

namespace backend.Services
{
    // Reads persisted KPI results and prepares the month-range aggregates used by the analytics views.
    public class AnalyticsService
    {
        private readonly AppDbContext _db;

        // The context is injected so read-only analytics queries can use the application database.
        public AnalyticsService(AppDbContext db)
        {
            _db = db;
        }

        // Averages each KPI/area combination across the requested months and adds the area's combined percentage.
        public async Task<List<AnalyticsResultDto>> GetCumulativeAnalyticsAsync(short year, byte startMonth, byte endMonth)
        {
            var rows = await _db.OverallKpiResults
                .AsNoTracking()
                .Where(x => x.Year == year && x.Month >= startMonth && x.Month <= endMonth)
                .ToListAsync();

            var results = rows
                .GroupBy(x => new
                {
                    x.KpiDefinitionId,
                    NormalizedAreaCode = (x.AreaCode ?? string.Empty).Trim().ToLowerInvariant()
                })
                .Select(g => new AnalyticsResultDto
                {
                    KpiDefinitionId = g.Key.KpiDefinitionId,
                    AreaCode = g.First().AreaCode,
                    KpiName = g.Max(x => x.KpiName),
                    Year = year,
                    AchievedKpi = Math.Round(g.Average(x => x.AchievedKpi), 4),
                    MaximumPointsPerKpi = Math.Round(g.Average(x => x.MaximumPointsPerKpi), 4),
                    PointsAchieved = Math.Round(g.Average(x => x.PointsAchieved), 4),
                    OverallKpiValuePercent = 0m
                })
                .OrderBy(x => x.KpiDefinitionId)
                .ThenBy(x => x.AreaCode)
                .ToList();

            var overallPercentByArea = results
                .GroupBy(x => x.AreaCode, StringComparer.OrdinalIgnoreCase)
                .ToDictionary(
                    g => g.Key,
                    g =>
                    {
                        var totalMax = g.Sum(x => x.MaximumPointsPerKpi);
                        var totalAchieved = g.Sum(x => x.PointsAchieved);
                        return totalMax > 0m
                            ? Math.Round((totalAchieved / totalMax) * 100m, 4)
                            : 0m;
                    },
                    StringComparer.OrdinalIgnoreCase);

            foreach (var row in results)
            {
                if (overallPercentByArea.TryGetValue(row.AreaCode, out var overallPercent))
                {
                    row.OverallKpiValuePercent = overallPercent;
                }
            }

            return results;
        }

        // Returns years for which calculated KPI results are available, newest first.
        public async Task<List<int>> GetAvailableYearsAsync()
        {
            return await _db.OverallKpiResults
                .AsNoTracking()
                .Select(x => (int)x.Year)
                .Distinct()
                .OrderByDescending(y => y)
                .ToListAsync();
        }

        // Returns calculated result months available for the selected year, newest first.
        public async Task<List<int>> GetAvailableMonthsAsync(short year)
        {
            return await _db.OverallKpiResults
                .AsNoTracking()
                .Where(x => x.Year == year)
                .Select(x => (int)x.Month)
                .Distinct()
                .OrderByDescending(m => m)
                .ToListAsync();
        }
    }
}
