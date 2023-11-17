namespace Blastmanager.Contractor.Entities.Api;

/// <summary>
/// 
/// </summary>
public abstract class Product
{
    /// <summary>
    /// 
    /// </summary>
    public int Id { get; init; }
    /// <summary>
    /// Name of product
    /// </summary>
    public string Name { get; init; } = null!;
    /// <summary>
    /// Type of product, ie. misc, explosives, lighters, bore meter
    /// </summary>
    public string Classification { get; init; } = null!;
    /// <summary>
    /// Quantity of <see cref="Name"/>
    /// </summary>
    public decimal Qty { get; init; }
    /// <summary>
    /// Unit of measurement of <see cref="Name"/>
    /// </summary>
    public string Unit { get; init; } = null!;
    /// <summary>
    /// Quantity of explosives that specified quantities contain
    /// </summary>
    public decimal NetExplosives { get; init; }
    /// <summary>
    /// Unit price based on the price list applicable at the time the volley was fired. Changing the value will not change LastChanged
    /// </summary>
    public decimal? UnitPrice { get; init; }
}