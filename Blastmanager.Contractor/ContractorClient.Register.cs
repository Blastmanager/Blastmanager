using System.Text;
using Blastmanager.Contractor.Entities;
using Blastmanager.Contractor.Entities.Constants;
using Blastmanager.Contractor.Entities.Interfaces;
using Blastmanager.Entities.Configs;
using Blastmanager.Entities.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Blastmanager.Contractor;

public sealed class ContractorClientRegister : IRegister
{
    /// <summary>
    /// Register the Contractor Client
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="configure"></param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
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
                    ? new(ApiUri.BaseUri)
                    : new(cfg.Proxy);

            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("User-Agent", "BlastManager Nuget Package");
            client.DefaultRequestHeaders.Add("Authorization",
                    $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes($"{cfg.Username}:{cfg.Password}"))}");
        });
    }
}