using Blastmanager.Contractor.Api;

namespace Blastmanager.Contractor.Entities;

public class Project
{
    /// <summary>
    /// Identifier for project in BlastManager on global level.
    /// Misfires and blast reports will reference this Id.
    /// </summary>
    public int Id { get; internal set; }

    /// <summary>
    /// Internal project number as provided in BlastManager
    /// </summary>
    public string ProjectNumber { get; internal set; } = null!;

    /// <summary>
    /// Name of project provided in BlastManager
    /// </summary>
    public string ProjectName { get; internal set; } = null!;

    /// <summary>
    /// Measurement points setup in projects
    /// </summary>
    public List<VibPoint> VibPointList { get; internal set; } = null!;

    /// <summary>
    /// List over available blast plans in project.
    /// </summary>
    public List<MethodStatementBlasting> MethodStatementBlastingList { get; internal set; } = null!;
}