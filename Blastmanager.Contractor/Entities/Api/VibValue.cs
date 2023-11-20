namespace Blastmanager.Contractor.Entities.Api;

public class VibValue
{
    /// <summary>
    /// Reference to <see cref="VibPoint.Id" />
    /// </summary>
    public int VibPointId { get; init; }
    /// <summary>
    /// Calculated vibration
    /// </summary>
    public decimal? CalculatedMaxValue { get; init; }
    /// <summary>
    /// Distance used in calculation of theoretical vibration
    /// </summary>
    public decimal? Distance { get; init; }
    /// <summary>
    /// Mountain constant (k-value)
    /// </summary>
    public decimal? RockConstant { get; init; }
    /// <summary>
    /// Actual measured vibration
    /// </summary>
    public decimal? MaxValue { get; init; }
    /// <summary>
    /// calculated new rock constant based on actual measurement
    /// </summary>
    public decimal? NewRockConstant { get; init; }
}