using Blastmanager.Entities.Interfaces;

namespace Blastmanager.Contractor.Entities.Interfaces;

/// <summary>
/// </summary>
public interface IContractorClient : IBaseClient
{
    /// <summary>
    /// </summary>
    /// <param name="onlyActive"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Project[]?> GetProjectsAsync(bool onlyActive, CancellationToken cancellationToken = default);

    /// <summary>
    /// </summary>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<BlastReport[]?> GetBlastReportsByBlastDateAsync(DateTime from, DateTime to,
            CancellationToken cancellationToken = default);

    /// <summary>
    /// </summary>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<BlastReport[]?> GetBlastReportsByLastChangedAsync(DateTime from, DateTime to,
            CancellationToken cancellationToken = default);

    /// <summary>
    /// </summary>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Misfire[]?> GetMisfiresByLastChangedAsync(DateTime from, DateTime to,
            CancellationToken cancellationToken = default);

    /// <summary>
    /// </summary>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Misfire[]?> GetMisfiresByFoundDateAsync(DateTime from, DateTime to,
            CancellationToken cancellationToken = default);
}