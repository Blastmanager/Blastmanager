namespace Blastmanager.Contractor.Entities;

public class Movements
{
    public Movement Estimated { get; internal set; } = new();
    public Movement Actual { get; internal set; } = new();
}