using System.Reflection;
using Blastmanager.Entities;
using Blastmanager.Entities.Interfaces;
using Microsoft.Extensions.Hosting;

namespace Blastmanager;

public static class BlastClientHostBuilder
{
    public static void AddBlastManager(this IHostBuilder builder, Action<BlastManagerConfig> configure)
    {
        var clients = Assembly.GetEntryAssembly()?.GetTypes()
                .Where(x => x.IsClass && typeof(IRegister).IsAssignableFrom(x))
                .ToArray();
        if (clients is null) throw new NullReferenceException("No clients found. Please install a client package");
        for (var i = 0; i < clients.Length; i++)
        {
            var x = clients[i];

            x.GetMethod("Register")?.Invoke(new object(), new object[] { });
        }
    }
}