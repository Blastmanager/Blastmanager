using Blastmanager.Contractor.Entities;
using Blastmanager.Contractor.Entities.Interfaces;
using Blastmanager.Entities;
using Blastmanager.Entities.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Blastmanager.Contractor;

public class ContractorClientRegister : IRegister
{
    public void Register(IHostBuilder builder, Action<BlastManagerConfig> configure)
    {
        builder.ConfigureServices((_, collection) =>
        {
            collection.AddScoped<IContractorClient, ContractorClient>();
            collection.AddHttpClient<IContractorClient, ContractorClient>(client =>
            {
                client.BaseAddress = new Uri("");
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.DefaultRequestHeaders.Add("User-Agent", "BlastManager Nuget Package");
            });
            collection.Configure(configure);
        });
    }
}