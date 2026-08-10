/*
 * File: IMultiTableService.cs
 * Service interface and DTOs for fetching normalized maintenance data from the platform tables.
 * Supports MSAN, VPN/IPNW, SLBN, and tower data retrieval.
 */

using backend.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace backend.Services
{
    // Provides a common response shape for the platform-specific maintenance tables.
    public interface IMultiTableService
    {
        Task<List<PlatformRecordDto>> FetchMsanDataAsync(int? year = null, int? month = null);
        Task<List<PlatformRecordDto>> FetchVpnDataAsync(int? year = null, int? month = null);
        Task<List<PlatformRecordDto>> FetchSlbnDataAsync(int? year = null, int? month = null);
        Task<List<PlatformRecordDto>> FetchTowerDataAsync(int? year = null, int? month = null);
    }

    // Represents one normalized month and the designation values belonging to that month.
    public class PlatformRecordDto
    {
        // Month name returned to the client after the service normalizes the source value.
        public string Month { get; set; } = string.Empty;

        // Legacy list-shaped response property retained for clients that use the original contract.
        public List<PlatformDetailDto> Details { get; set; } = new();

        // Fast lookup of designation to maintenance detail used by the current platform views.
        public Dictionary<string, PlatformDetailDto>? Data { get; internal set; }
    }

    // PlatformDetailDto is defined in backend.DTOs and contains the values for one designation.
   
}
