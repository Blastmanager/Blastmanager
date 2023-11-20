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
    public void Register(IServiceCollection builder, Action<BlastManagerConfig> configure)
    { 
        var cfg = new ContractorOption 
        { 
                Username = string.Empty, 
                Password = string.Empty 
        }; 
        configure.Invoke(cfg);
        
        builder.Configure<ContractorOption>(configure);
        switch (cfg.ServiceLifetime)
        {
            case ServiceLifetime.Singleton:
                builder.AddSingleton<IContractorClient, ContractorClient>(); 
                break;
            case ServiceLifetime.Scoped:
                builder.AddScoped<IContractorClient, ContractorClient>(); 
                break;
            case ServiceLifetime.Transient:
                builder.AddTransient<IContractorClient, ContractorClient>(); 
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        builder.AddScoped<IContractorClient, ContractorClient>(); 
        builder.AddHttpClient<IContractorClient, ContractorClient>(client => 
        { 
            client.BaseAddress = cfg.Proxy is null 
                    ? new (ApiUri.BaseUri) 
                    : new (cfg.Proxy);
            
            client.DefaultRequestHeaders.Add("Accept", "application/json"); 
            client.DefaultRequestHeaders.Add("User-Agent", "BlastManager Nuget Package"); 
            client.DefaultRequestHeaders.Add("Authorization", 
                    $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes($"{cfg.Username}:{cfg.Password}"))}"); 
        }); 
    } 
}