using System.Reflection;
using Blastmanager.Entities.Configs;
using Blastmanager.Entities.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Blastmanager;

public static class BlastClientHostBuilder
{
    /// <summary>
    /// Configure BlastManager and all installed clients
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="configure"></param>
    /// <exception cref="NullReferenceException">
    /// When no clients have been installed,
    /// or there's no referenced assemblies
    /// </exception>
    public static void AddBlastManager(this IServiceCollection builder, Action<BlastManagerConfig> configure)
    {
        var types = Assembly.GetEntryAssembly()?.GetReferencedAssemblies();
        if (types is null) throw new NullReferenceException("No referenced assemblies found.");
        for (var i = 0; i < types.Length; i++)
        {
            var x = types[i];
            if (x.Name is not null && !x.Name.StartsWith("Blastmanager.")) continue;
            var assembly = Assembly.Load(x);
            var client = assembly.GetTypes()
                    .Where(type => type.IsClass && typeof(IRegister).IsAssignableFrom(type))
                    .ToArray();
            for (var j = 0; j < client.Length; j++)
            {
                var type = client[j];
                type.GetMethod("Register")
                        ?.Invoke(Activator.CreateInstance(type), new object[] { builder, configure });
            }
        }
    }
}