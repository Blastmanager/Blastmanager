namespace Blastmanager.Entities;

public record BlastManagerConfig
{
    protected BlastManagerConfig(string username, string password, string proxy = null!)
    {
        this.Username = username;
        this.Password = password;
        this.Proxy = proxy;
    }

    public required string Username { get; init; }
    public required string Password { get; init; }
    public string? Proxy { get; init; }
}