using Microsoft.Extensions.Hosting;

namespace Blastmanager.Entities.Interfaces;

public interface IRegister
{
    void Register(IHostBuilder builder, Action<BlastManagerConfig> configure);
}