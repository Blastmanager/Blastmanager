using System.Text.Json.Serialization;

namespace Blastmanager.Contractor.Entities.Api;

public class Coordinate
{
    /// <summary>
    /// Latitude Coordinates
    /// </summary>
    [JsonPropertyName("Latitude")]
    public decimal? Latitude { get; init; }
    /// <summary>
    /// Longitude Coordinates
    /// </summary>
    [JsonPropertyName("Longitude")]
    public decimal? Longitude { get; init; }
    /// <summary>
    /// Height above sea level
    /// </summary>
    [JsonPropertyName("Z")]
    public decimal? Z { get; init; }
    /// <summary>
    /// North coordinate in local coordination system
    /// </summary>
    [JsonPropertyName("Northing")]
    public decimal? Northing { get; init; }
    /// <summary>
    /// East coordinate in local coordination system
    /// </summary>
    [JsonPropertyName("Easting")]
    public decimal? Easting { get; init; }
    /// <summary>
    /// Reference to local coordination system
    /// </summary>
    [JsonPropertyName("Epsg")]
    public string Epsg { get; init; }
}