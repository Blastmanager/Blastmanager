using System.Text;
using Blastmanager.Contractor.Entities;
using Blastmanager.Contractor.Entities.Constants;
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
            var cfg = new ContractorOption
            {
                    Username = string.Empty,
                    Password = string.Empty
            };
            configure.Invoke(cfg);
           
            collection.Configure<ContractorOption>(configure);
            collection.AddScoped<IContractorClient, ContractorClient>();
            collection.AddHttpClient<IContractorClient, ContractorClient>(client =>
            {
                client.BaseAddress = cfg.Proxy is null 
                        ? new (ApiUri.BaseUri) 
                        : new (cfg.Proxy);
                
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.DefaultRequestHeaders.Add("User-Agent", "BlastManager Nuget Package");
                client.DefaultRequestHeaders.Add("Authorization",
                        $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes($"{cfg.Username}:{cfg.Password}"))}");
            });
        });
    }
}