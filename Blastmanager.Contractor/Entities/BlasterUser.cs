namespace Blastmanager.Contractor.Entities;

/// <summary>
/// Information about a blaster
/// </summary>
public class BlasterUser
{
    /// <summary>
    /// Id of the user
    /// </summary>
    public int Id { get; internal set; }
    /// <summary>
    /// Full name of blaster
    /// </summary>
    public string Name { get; internal set; } = null!;
    /// <summary>
    /// Employment number of blaster
    /// </summary>
    public string EmploymentNumber { get; internal set; } = null!;
}