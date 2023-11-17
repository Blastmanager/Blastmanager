namespace Blastmanager.Contractor.Entities.Api;

public abstract class Coordinate
{
    /// <summary>
    /// Latitude Coordinates
    /// </summary>
    public decimal? Latitude { get; init; }
    /// <summary>
    /// Longitude Coordinates
    /// </summary>
    public decimal? Longitude { get; init; }
    /// <summary>
    /// Height above sea level
    /// </summary>
    public decimal? Z { get; init; }
    /// <summary>
    /// North coordinate in local coordination system
    /// </summary>
    public decimal? Northing { get; init; }
    /// <summary>
    /// East coordinate in local coordination system
    /// </summary>
    public decimal? Easting { get; init; }
    /// <summary>
    /// Reference to local coordination system
    /// </summary>
    public int Epsg { get; init; }
}