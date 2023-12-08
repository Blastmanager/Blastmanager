using System.Text.Json.Serialization;

namespace Blastmanager.Contractor.Api;

public class Coordinate
{
    /// <summary>
    /// Latitude Coordinates
    /// </summary>
    [JsonPropertyName("Latitude")]
    public decimal? Latitude { get; internal set; }

    /// <summary>
    /// Longitude Coordinates
    /// </summary>
    [JsonPropertyName("Longitude")]
    public decimal? Longitude { get; internal set; }

    /// <summary>
    /// Height above sea level
    /// </summary>
    [JsonPropertyName("Z")]
    public decimal? Z { get; internal set; }

    /// <summary>
    /// North coordinate in local coordination system
    /// </summary>
    [JsonPropertyName("Northing")]
    public decimal? Northing { get; internal set; }

    /// <summary>
    /// East coordinate in local coordination system
    /// </summary>
    [JsonPropertyName("Easting")]
    public decimal? Easting { get; internal set; }

    /// <summary>
    /// Reference to local coordination system
    /// </summary>
    [JsonPropertyName("Epsg")]
    public string Epsg { get; internal set; }
}