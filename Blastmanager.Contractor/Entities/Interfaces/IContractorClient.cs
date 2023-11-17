using Blastmanager.Entities.Interfaces;

namespace Blastmanager.Contractor.Entities.Interfaces;

public interface IContractorClient : IBaseClient
{
    ValueTask GetProjectsAsync(bool onlyActive, CancellationToken cancellationToken = default);
    void GetProjects(bool onlyActive);

    ValueTask GetBlastReportsByBlastDateAsync(DateTime from, DateTime to, CancellationToken cancellationToken = default);
    void GetBlastReportsByBlastDate(DateTime from, DateTime to);

    ValueTask GetBlastReportsByLastChangedAsync(DateTime from, DateTime to, CancellationToken cancellationToken = default);
    void GetBlastReportsByLastChanged(DateTime from, DateTime to);

    ValueTask GetMisFiresByLastChangedAsync(DateTime from, DateTime to, CancellationToken cancellationToken = default);
    void GetMisFiresByLastChanged(DateTime from, DateTime to);
    
    ValueTask GetMisFiresByFoundDateAsync(DateTime from, DateTime to, CancellationToken cancellationToken = default);
    void GetMisFiresByFoundDate(DateTime from, DateTime to);
}