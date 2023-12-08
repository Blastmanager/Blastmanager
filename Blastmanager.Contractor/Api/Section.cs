using System.Text.Json.Serialization;

namespace Blastmanager.Contractor.Api;

/// <summary>
/// </summary>
public class Section
{
    /// <summary>
    /// Type - Section/Element. Example: Outline, emergency room etc
    /// </summary>
    public string Type { get; internal set; } = null!;

    /// <summary>
    /// Hole spacing
    /// </summary>
    public decimal Spacing { get; internal set; }

    /// <summary>
    /// Burden
    /// </summary>
    public decimal Burden { get; internal set; }

    /// <summary>
    /// Ankle of hole. 0 = vertical
    /// </summary>
    public decimal HoleAngle { get; internal set; }

    /// <summary>
    /// Diameter in millimeter in bore hole
    /// </summary>
    public int Diameter { get; internal set; }

    /// <summary>
    /// Hole count
    /// </summary>
    public int Holes { get; internal set; }

    /// <summary>
    /// Row count
    /// </summary>
    public int Rows { get; internal set; }

    /// <summary>
    /// Total meter bore hole in section
    /// </summary>
    public decimal TotalHoleDepth { get; internal set; }

    public decimal Stemming { get; internal set; }

    [JsonPropertyName("BottomCharge_CartridgeDiameter")]
    public int? BottomChargeCartridgeDiameter { get; internal set; }

    [JsonPropertyName("BottomCharge_CartridgeLength")]
    public int BottomChargeCartridgeLength { get; internal set; }

    [JsonPropertyName("BottomCharge_CartridgeWeight")]
    public int BottomChargeCartridgeWeight { get; internal set; }

    [JsonPropertyName("BottomCharge_CartridgesPerHole")]
    public decimal BottomChargeCartridgesPerHole { get; internal set; }

    [JsonPropertyName("ColumnCharge_Dencity")]
    public decimal ColumnChargeDencity { get; internal set; }

    [JsonPropertyName("ColumnCharge_CartridgeLength")]
    public int ColumnChargeCartridgeLength { get; internal set; }

    [JsonPropertyName("ColumnCharge_CartridgeWeight")]
    public int ColumnChargeCartridgeWeight { get; internal set; }

    public decimal InterdeckLength { get; internal set; }
}