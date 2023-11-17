namespace Blastmanager.Entities;

public record BlastManagerConfig
{
    protected BlastManagerConfig(string username, string password, string proxy = null!)
    {
        this.Username = username;
        this.Password = password;
        this.Proxy = proxy;
    }

    public string Username { get; init; }
    public string Password { get; init; }
    public string Proxy { get; init; }
}