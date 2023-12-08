namespace Blastmanager.Contractor.Api;

public class VibValue
{
    /// <summary>
    /// Reference to <see cref="VibPoint.Id" />
    /// </summary>
    public int VibPointId { get; internal set; }

    /// <summary>
    /// Calculated vibration
    /// </summary>
    public decimal? CalculatedMaxValue { get; internal set; }

    /// <summary>
    /// Distance used in calculation of theoretical vibration
    /// </summary>
    public decimal? Distance { get; internal set; }

    /// <summary>
    /// Mountain constant (k-value)
    /// </summary>
    public decimal? RockConstant { get; internal set; }

    /// <summary>
    /// Actual measured vibration
    /// </summary>
    public decimal? MaxValue { get; internal set; }

    /// <summary>
    /// calculated new rock constant based on actual measurement
    /// </summary>
    public decimal? NewRockConstant { get; internal set; }
}