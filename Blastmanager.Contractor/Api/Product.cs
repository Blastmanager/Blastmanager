namespace Blastmanager.Contractor.Api;

/// <summary>
/// </summary>
public class Product
{
    /// <summary>
    /// </summary>
    public int Id { get; internal set; }

    /// <summary>
    /// Name of product
    /// </summary>
    public string Name { get; internal set; } = null!;

    /// <summary>
    /// Type of product, ie. misc, explosives, lighters, bore meter
    /// </summary>
    public string Classification { get; internal set; } = null!;

    /// <summary>
    /// Product category
    /// </summary>
    public string Category { get; internal set; } = string.Empty;

    /// <summary>
    /// The supplier of product
    /// </summary>
    public string Supplier { get; internal set; } = string.Empty;

    /// <summary>
    /// Quantity of <see cref="Name" />
    /// </summary>
    public decimal Qty { get; internal set; }

    /// <summary>
    /// Unit of measurement of <see cref="Name" />
    /// </summary>
    public string Unit { get; internal set; } = null!;

    /// <summary>
    /// Quantity of explosives that specified quantities contain
    /// </summary>
    public decimal NetExplosives { get; internal set; }

    /// <summary>
    /// Unit price based on the price list applicable at the time the volley was fired. Changing the value will not change
    /// LastChanged
    /// </summary>
    public decimal? UnitPrice { get; internal set; }

    /// <summary>
    /// Products UN-number which specifies the dangerous substance or article which is transported
    /// </summary>
    public int? UnNumber { get; internal set; }
}