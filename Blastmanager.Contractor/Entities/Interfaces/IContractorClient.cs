using Blastmanager.Contractor.Entities.Response;
using Blastmanager.Entities.Interfaces;

namespace Blastmanager.Contractor.Entities.Interfaces;

/// <summary>
/// 
/// </summary>
public interface IContractorClient : IBaseClient
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="onlyActive"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<GetProjectsResponse[]> GetProjectsAsync(bool onlyActive, CancellationToken cancellationToken = default);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<BlastReportsResponse[]> GetBlastReportsByBlastDateAsync(DateTime from, DateTime to, CancellationToken cancellationToken = default);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<BlastReportsResponse[]> GetBlastReportsByLastChangedAsync(DateTime from, DateTime to, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<GetMisfireResponse[]> GetMisfiresByLastChangedAsync(DateTime from, DateTime to, CancellationToken cancellationToken = default);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<GetMisfireResponse[]> GetMisfiresByFoundDateAsync(DateTime from, DateTime to, CancellationToken cancellationToken = default);
}