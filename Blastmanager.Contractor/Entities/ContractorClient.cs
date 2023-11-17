using Blastmanager.Contractor.Entities.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Blastmanager.Contractor.Entities;

public abstract class ContractorClient(IOptions<object> options, 
                IHttpClientFactory factory,
                ILogger<ContractorClient> logger) 
        : IContractorClient
{
    private readonly HttpClient _client = factory.CreateClient();
    private readonly ILogger<ContractorClient> _logger = logger;
    private readonly IOptions<object> _options = options;

    public async ValueTask GetProjectsAsync(bool onlyActive, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void GetProjects(bool onlyActive)
    {
        throw new NotImplementedException();
    }

    public async ValueTask GetBlastReportsByBlastDateAsync(DateTime from, DateTime to, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void GetBlastReportsByBlastDate(DateTime from, DateTime to)
    {
        throw new NotImplementedException();
    }

    public async ValueTask GetBlastReportsByLastChangedAsync(DateTime from, DateTime to, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void GetBlastReportsByLastChanged(DateTime from, DateTime to)
    {
        throw new NotImplementedException();
    }

    public async ValueTask GetMisFiresByLastChangedAsync(DateTime from, DateTime to, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void GetMisFiresByLastChanged(DateTime from, DateTime to)
    {
        throw new NotImplementedException();
    }

    public async ValueTask GetMisFiresByFoundDateAsync(DateTime from, DateTime to, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void GetMisFiresByFoundDate(DateTime from, DateTime to)
    {
        throw new NotImplementedException();
    }
}