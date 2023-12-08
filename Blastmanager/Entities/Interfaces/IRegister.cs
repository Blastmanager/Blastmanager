using Blastmanager.Entities.Configs;
using Microsoft.Extensions.DependencyInjection;

namespace Blastmanager.Entities.Interfaces;

public interface IRegister
{
    void Register(IServiceCollection builder, Action<BlastManagerConfig> configure);
}