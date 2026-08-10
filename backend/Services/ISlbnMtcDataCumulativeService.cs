namespace backend.Services
{
    // Rebuilds the two-month cumulative fields in the SLBN maintenance table.
    public interface ISlbnMtcDataCumulativeService
    {
        Task<SlbnMtcDataBackfillResult> RecalculateAllAsync();
        Task<int> RecalculateAsync(string designation, int year);
    }

    // Reports the scope and number of changes made by a cumulative-data rebuild.
    public sealed record SlbnMtcDataBackfillResult(
        int TotalRecords,
        int GroupsProcessed,
        int RecordsUpdated);
}
