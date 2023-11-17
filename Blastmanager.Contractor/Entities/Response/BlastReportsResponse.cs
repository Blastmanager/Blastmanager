using Blastmanager.Contractor.Entities.Api;

namespace Blastmanager.Contractor.Entities.Response;

public class BlastReportsResponse : Coordinate
{
    public int Id { get; init; }
    public int ProjectId { get; init; }
    public string ProjectName { get; init; } = null!;
    public string ProjectNumber { get; init; } = null!;
    public int Number { get; init; }
    public string Title { get; init; } = null!;
    public string Contractor { get; init; } = null!;
    public string Type { get; init; } = null!;
    public DateTime BlastPlanCreated { get; init; }
    public DateTime BlastReportCreated { get; init; }
    public DateTime PlannedFire { get; init; }
    public DateTime ActualFired { get; init; }
    public DateTime LastChanged { get; init; }
    public int RevisionNumber { get; init; }
    public decimal VolumePlan { get; init; }
    public decimal VolumeReport { get; init; }
    public int HolesPlan { get; init; }
    public int HolesReport { get; init; }
    public decimal TheoreticalExplosives { get; init; }
    public decimal? ActualExplosives { get; init; }
    public decimal? EstimatedMovementFront { get; init; }
    public decimal? EstimatedMovementBack { get; init; }
    public decimal? EstimatedMovementLeft { get; init; }
    public decimal? EstimatedMovementRight { get; init; }
    public decimal? ActualMovementFront { get; init; }
    public decimal? ActualMovementBack { get; init; }
    public decimal? ActualMovementLeft { get; init; }
    public decimal? ActualMovementRight { get; init; }
    public int MethodStatementBlastingId { get; init; }
    public List<int> AsBuiltConcaveHullIdList { get; init; } = null!;
    public int? DirectionDegree { get; init; }
    public List<Product> Products { get; init; } = null!;
    public List<VibValue> VibValues { get; init; } = null!;
    public List<Section> Sections { get; init; } = null!;
    public List<AsBuiltHoles> AsBuiltHoles { get; init; } = null!;
    public int PopulationAlertReceivers { get; init; }
    public DateTime? PopulationAlertSentDate { get; init; }
    public string BlasterName { get; init; } = null!;
    public int BlasterId { get; init; }
    public string BlasterEmploymentNumber { get; init; } = null!;
    public decimal MaxChargePerDelay { get; init; }
    public decimal? TunnelRoundArea { get; init; }
    public decimal? TunnelRoundLength { get; init; }
}