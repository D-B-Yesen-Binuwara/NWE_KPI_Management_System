using backend.Data;
using backend.DTOs;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Services
{
    // Exposes CRUD operations for the KPI definitions used by calculation and administration screens.
    public interface IKpiDefinitionService
    {
        Task<List<KpiDefinitionDto>> GetAllAsync();
        Task<KpiDefinitionDto?> GetByIdAsync(int id);
        Task<KpiDefinitionDto> CreateAsync(UpsertKpiDefinitionDto dto);
        Task<KpiDefinitionDto?> UpdateAsync(int id, UpsertKpiDefinitionDto dto);
        Task<bool> DeleteAsync(int id);
    }

    // Keeps KPI definitions and their shared-point weightages consistent after each change.
    public class KpiDefinitionService : IKpiDefinitionService
    {
        private readonly AppDbContext _db;

        // Uses the application context for definition reads and updates.
        public KpiDefinitionService(AppDbContext db)
        {
            _db = db;
        }

        // Reads definitions without tracking because the returned entities are mapped to DTOs only.
        public async Task<List<KpiDefinitionDto>> GetAllAsync()
        {
            var rows = await _db.KpiDefinitions
                .AsNoTracking()
                .OrderBy(x => x.Id)
                .ToListAsync();

            return rows.Select(ToDto).ToList();
        }

        // Looks up one definition and returns null when the requested ID is not present.
        public async Task<KpiDefinitionDto?> GetByIdAsync(int id)
        {
            var entity = await _db.KpiDefinitions
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            return entity is null ? null : ToDto(entity);
        }

        // Normalizes submitted text, persists the new definition, then recalculates all weightages.
        public async Task<KpiDefinitionDto> CreateAsync(UpsertKpiDefinitionDto dto)
        {
            var now = DateTime.UtcNow.ToString("o");
            var totalPoints = ResolveTotalPoints(dto.TotalPoints);

            var entity = new KpiDefinition
            {
                Perspectives = dto.Perspectives.Trim(),
                StrategicObjectives = dto.StrategicObjectives.Trim(),
                KeyPerformanceIndicators = dto.KeyPerformanceIndicators.Trim(),
                Unit = dto.Unit.Trim(),
                DescriptionOfKPI = dto.DescriptionOfKPI.Trim(),
                Category = dto.Category?.Trim() ?? string.Empty,
                EngineerResponsible = dto.EngineerResponsible?.Trim() ?? string.Empty,
                PointsApplicable = dto.PointsApplicable,
                TotalPoints = totalPoints,
                Weightage = 0m,
                CreatedAt = now,
                UpdatedAt = now
            };

            _db.KpiDefinitions.Add(entity);
            await _db.SaveChangesAsync();

            await RecalculateWeightageAsync(totalPoints);

            return ToDto(await _db.KpiDefinitions.AsNoTracking().FirstAsync(x => x.Id == entity.Id));
        }

        // Updates an existing definition and reuses the shared denominator for every KPI row.
        public async Task<KpiDefinitionDto?> UpdateAsync(int id, UpsertKpiDefinitionDto dto)
        {
            var entity = await _db.KpiDefinitions.FirstOrDefaultAsync(x => x.Id == id);
            if (entity is null) return null;

            entity.Perspectives = dto.Perspectives.Trim();
            entity.StrategicObjectives = dto.StrategicObjectives.Trim();
            entity.KeyPerformanceIndicators = dto.KeyPerformanceIndicators.Trim();
            entity.Unit = dto.Unit.Trim();
            entity.DescriptionOfKPI = dto.DescriptionOfKPI.Trim();
            entity.Category = dto.Category?.Trim() ?? entity.Category;
            entity.EngineerResponsible = dto.EngineerResponsible?.Trim() ?? entity.EngineerResponsible;
            entity.PointsApplicable = dto.PointsApplicable;
            entity.TotalPoints = ResolveTotalPoints(dto.TotalPoints ?? entity.TotalPoints);
            entity.UpdatedAt = DateTime.UtcNow.ToString("o");

            await _db.SaveChangesAsync();
            await RecalculateWeightageAsync(entity.TotalPoints);

            return ToDto(await _db.KpiDefinitions.AsNoTracking().FirstAsync(x => x.Id == entity.Id));
        }

        // Deletes a definition and rebalances the remaining definitions' weightages.
        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _db.KpiDefinitions.FirstOrDefaultAsync(x => x.Id == id);
            if (entity is null) return false;

            _db.KpiDefinitions.Remove(entity);
            await _db.SaveChangesAsync();

            await RecalculateWeightageAsync();
            return true;
        }

        // Applies one total-points denominator to every row so individual weightages remain comparable.
        private async Task RecalculateWeightageAsync(int? totalPointsOverride = null)
        {
            var rows = await _db.KpiDefinitions.ToListAsync();
            if (rows.Count == 0) return;

            var denominator = (decimal)ResolveTotalPoints(totalPointsOverride ?? rows[0].TotalPoints);

            foreach (var r in rows)
            {
                r.TotalPoints = (int)denominator;
                r.Weightage = denominator > 0m
                    ? Math.Round((decimal)r.PointsApplicable / denominator * 100m, 4)
                    : 0m;
            }

            await _db.SaveChangesAsync();
        }

        // Uses the system default when a caller omits or supplies an invalid total-points value.
        private static int ResolveTotalPoints(int? value)
            => value.HasValue && value.Value > 0 ? value.Value : 36000;

        // Keeps database entities from crossing the service boundary into controller responses.
        private static KpiDefinitionDto ToDto(KpiDefinition x) => new()
        {
            Id = x.Id,
            Perspectives = x.Perspectives,
            StrategicObjectives = x.StrategicObjectives,
            KeyPerformanceIndicators = x.KeyPerformanceIndicators,
            Unit = x.Unit,
            DescriptionOfKPI = x.DescriptionOfKPI,
            Category = x.Category,
            EngineerResponsible = x.EngineerResponsible,
            Weightage = x.Weightage,
            PointsApplicable = x.PointsApplicable,
            TotalPoints = x.TotalPoints,
            CreatedAt = x.CreatedAt,
            UpdatedAt = x.UpdatedAt
        };
    }
}
