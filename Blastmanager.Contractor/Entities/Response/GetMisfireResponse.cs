namespace Blastmanager.Contractor.Entities.Response;

internal class GetMisfireResponse
{
    public int Id { get; set; }
    public DateTime TimestampCreated { get; set; }
    public DateTime TimestampFound { get; set; }
    public DateTime TimestampLastChanged { get; set; }
    public decimal? Northing { get; set; }
    public decimal? Easting { get; set; }
    public int ProjectId { get; set; }
    public string ProjectName { get; set; } = null!;
    public string ProjectNumber { get; set; } = null!;
    public int StatusId { get; set; }
    public string Status { get; set; } = null!;
    public int? BlastId { get; set; }
    public decimal? AmountExplosives { get; set; }
    public decimal? AmountDetonators { get; set; }
    public decimal? AmountCord { get; set; }
    public decimal? AmountPrimers { get; set; }
    public string Source { get; set; } = null!;
    public string ReportedAuthority { get; set; }
    public string DetonatorType { get; set; }
    public string ExplosiveTypes { get; set; }
    public string PotentialReasons { get; set; }
    public string Primer { get; set; }
    public string Comment { get; set; }
    public string MisfireContent { get; set; }
    public string FixedHow { get; set; }
    public string ReasonText { get; set; }
    public string FixedHowText { get; set; }
    public string BlastType { get; set; }
    public string FoundHow { get; set; }
}