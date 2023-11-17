using Blastmanager.Contractor.Entities.Api;

namespace Blastmanager.Contractor.Entities.Response;

/// <summary>
/// 
/// </summary>
public class GetProjectsResponse
{
    /// <summary>
    /// Identifier for project in BlastManager on global level.
    /// Misfires and blast reports will reference this Id.
    /// </summary>
    public int Id { get; init; }
    /// <summary>
    /// Internal project number as provided in BlastManager
    /// </summary>
    public string ProjectNumber { get; init; } = null!;
    /// <summary>
    /// Name of project provided in BlastManager
    /// </summary>
    public string ProjectName { get; init; } = null!;
    /// <summary>
    /// Measurement points setup in projects
    /// </summary>
    public List<VibPoint> VibPointList { get; init; } = null!;
    /// <summary>
    /// List over available blast plans in project.
    /// </summary>
    public List<MethodStatementBlasting> MethodStatementBlastingList { get; init; } = null!;
}