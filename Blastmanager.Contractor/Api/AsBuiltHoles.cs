namespace Blastmanager.Contractor.Api;

public class AsBuiltHoles
{
    public int Id { get; internal set; }
    public DateTime StartTime { get; internal set; }
    public DateTime EndTime { get; internal set; }
    public int EpsgCode { get; internal set; }
    public decimal StartEasting { get; internal set; }
    public decimal StartNorthing { get; internal set; }
    public decimal StartHeight { get; internal set; }
    public decimal EndEasting { get; internal set; }
    public decimal EndNorthing { get; internal set; }
    public decimal EndHeight { get; internal set; }
    public string HoleRef { get; internal set; } = null!;
    public string HoleType { get; internal set; } = null!;
    public int? ToolDim { get; internal set; }
    public string ErrorCode { get; internal set; } = null!;
    public string Comment { get; internal set; } = null!;
    public decimal Angle { get; internal set; }
    public decimal Heading { get; internal set; }
    public decimal Depth { get; internal set; }
    public string Status { get; internal set; } = null!;
    public decimal? StartGeoX { get; internal set; }
    public decimal? StartGeoY { get; internal set; }
    public decimal? EndGeoX { get; internal set; }
    public decimal? EndGeoY { get; internal set; }
}