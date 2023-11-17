namespace Blastmanager.Contractor.Entities.Api;

public abstract class AsBuiltHoles
{
    public int Id { get; init; }
    public DateTime StartTime { get; init; }
    public DateTime EndTime { get; init; }
    public int EpsgCode { get; init; }
    public decimal StartEasting { get; init; }
    public decimal StartNorthing { get; init; }
    public decimal StartHeight { get; init; }
    public decimal EndEasting { get; init; }
    public decimal EndNorthing { get; init; }
    public decimal EndHeight { get; init; }
    public string HoleRef { get; init; } = null!;
    public string HoleType { get; init; } = null!;
    public int? ToolDim { get; init; }
    public string ErrorCode { get; init; } = null!;
    public string Comment { get; init; } = null!;
    public decimal Angle { get; init; }
    public decimal Heading { get; init; }
    public decimal Depth { get; init; }
    public string Status { get; init; } = null!;
    public decimal? StartGeoX { get; init; }
    public decimal? StartGeoY { get; init; }
    public decimal? EndGeoX { get; init; }
    public decimal? EndGeoY { get; init; }
}