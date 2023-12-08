using Blastmanager.Entities.Configs;

namespace Blastmanager.Contractor.Entities;

public record ContractorOption : BlastManagerConfig
{
    internal ContractorOption() : base(string.Empty, string.Empty)
    {
    }

    public ContractorOption(string username, string password, string proxy = null!) : base(username, password, proxy)
    {
    }
}