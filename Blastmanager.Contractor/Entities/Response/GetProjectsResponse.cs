﻿using System.Text.Json.Serialization;
using Blastmanager.Contractor.Api;

namespace Blastmanager.Contractor.Entities.Response;

/// <summary>
/// </summary>
internal class GetProjectsResponse
{
    /// <summary>
    /// Identifier for project in BlastManager on global level.
    /// Misfires and blast reports will reference this Id.
    /// </summary>
    [JsonPropertyName("Id")]
    public int Id { get; internal set; }

    /// <summary>
    /// Internal project number as provided in BlastManager
    /// </summary>
    [JsonPropertyName("ProjectNumber")]
    public string ProjectNumber { get; internal set; } = null!;

    /// <summary>
    /// Name of project provided in BlastManager
    /// </summary>
    [JsonPropertyName("ProjectName")]
    public string ProjectName { get; internal set; } = null!;

    /// <summary>
    /// Measurement points setup in projects
    /// </summary>
    [JsonPropertyName("VibPointList")]
    public List<VibPoint> VibPointList { get; internal set; } = null!;

    /// <summary>
    /// List over available blast plans in project.
    /// </summary>
    [JsonPropertyName("MethodStatementBlastingList")]
    public List<MethodStatementBlasting> MethodStatementBlastingList { get; internal set; } = null!;
}