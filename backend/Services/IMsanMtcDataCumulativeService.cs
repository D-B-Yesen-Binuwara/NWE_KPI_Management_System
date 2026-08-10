namespace backend.Services
{
    // Rebuilds the half-year cumulative fields in the MSAN maintenance table.
    public interface IMsanMtcDataCumulativeService
    {
        Task<MsanMtcDataBackfillResult> RecalculateAllAsync();
        Task<int> RecalculateAsync(string designation, int year);
    }

    // Reports the scope and number of changes made by a cumulative-data rebuild.
    public sealed record MsanMtcDataBackfillResult(
        int TotalRecords,
        int GroupsProcessed,
        int RecordsUpdated);
}
