namespace backend.Services
{
    // Common result returned by each routine-maintenance source-table calculation.
    public record RoutineMaintenanceResult(
        string Designation,
        string NormalizedAreaCode,
        decimal Percentage,
        decimal NodesCount = 0m);
}
