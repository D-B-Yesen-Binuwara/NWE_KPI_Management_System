namespace backend.Services
{
    // Rebuilds the two-month cumulative fields in the IPNW maintenance table.
    public interface IIpnwMtcDataCumulativeService
    {
        Task<IpnwMtcDataBackfillResult> RecalculateAllAsync();
        Task<int> RecalculateAsync(string designation, int year);
    }

    // Reports the scope and number of changes made by a cumulative-data rebuild.
    public sealed record IpnwMtcDataBackfillResult(
        int TotalRecords,
        int GroupsProcessed,
        int RecordsUpdated);
}
