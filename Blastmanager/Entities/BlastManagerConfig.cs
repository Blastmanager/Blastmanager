using Microsoft.Extensions.DependencyInjection;

namespace Blastmanager.Entities;

public record BlastManagerConfig
{
    protected BlastManagerConfig(string username, string password, string proxy = null!)
    {
        Username = username;
        Password = password;
        Proxy = proxy;
    }

    public string Username { get; set; }
    public string Password { get; set; }
    public string? Proxy { get; init; }
    public ServiceLifetime ServiceLifetime { get; set; } = ServiceLifetime.Scoped;
}