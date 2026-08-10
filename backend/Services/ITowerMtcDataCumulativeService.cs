namespace backend.Services
{
    // Rebuilds the quarterly cumulative fields in the tower maintenance table.
    public interface ITowerMtcDataCumulativeService
    {
        Task<TowerMtcDataBackfillResult> RecalculateAllAsync();
        Task<int> RecalculateAsync(string designation, int year);
    }

    // Reports the scope and number of changes made by a cumulative-data rebuild.
    public sealed record TowerMtcDataBackfillResult(
        int TotalRecords,
        int GroupsProcessed,
        int RecordsUpdated);
}
