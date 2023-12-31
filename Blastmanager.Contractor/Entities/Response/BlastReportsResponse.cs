﻿using Blastmanager.Contractor.Api;

namespace Blastmanager.Contractor.Entities.Response;

internal class BlastReportsResponse : Coordinate
{
    public int Id { get; internal set; }
    public int ProjectId { get; internal set; }
    public string ProjectName { get; internal set; } = null!;
    public string ProjectNumber { get; internal set; } = null!;
    public int Number { get; internal set; }
    public string Title { get; internal set; } = null!;
    public string Contractor { get; internal set; } = null!;
    public string Type { get; internal set; } = null!;
    public DateTime BlastPlanCreated { get; internal set; }
    public DateTime BlastReportCreated { get; internal set; }
    public DateTime PlannedFire { get; internal set; }
    public DateTime ActualFired { get; internal set; }
    public DateTime LastChanged { get; internal set; }
    public int RevisionNumber { get; internal set; }
    public decimal AreaPlan { get; internal set; }
    public decimal AreaReport { get; internal set; }

    public decimal VolumePlan { get; internal set; }
    public decimal VolumeReport { get; internal set; }
    public int HolesPlan { get; internal set; }
    public int HolesReport { get; internal set; }

    public decimal DrillmetersPlan { get; internal set; }
    public decimal DrillmetersReport { get; internal set; }
    public decimal ActualDrillmeters { get; internal set; }

    public decimal TheoreticalExplosivesPlan { get; set; }
    internal decimal TheoreticalExplosives { get; set; }
    public decimal TheoreticalExplosivesReport { get; set; }
    public decimal? ActualExplosives { get; internal set; }
    public decimal? EstimatedMovementFront { get; internal set; }
    public decimal? EstimatedMovementBack { get; internal set; }
    public decimal? EstimatedMovementLeft { get; internal set; }
    public decimal? EstimatedMovementRight { get; internal set; }
    public decimal? ActualMovementFront { get; internal set; }
    public decimal? ActualMovementBack { get; internal set; }
    public decimal? ActualMovementLeft { get; internal set; }
    public decimal? ActualMovementRight { get; internal set; }
    public int MethodStatementBlastingId { get; internal set; }
    public List<int> AsBuiltConcaveHullIdList { get; internal set; } = null!;
    public int? DirectionDegree { get; internal set; }
    public List<Product> Products { get; internal set; } = null!;
    public List<VibValue> VibValues { get; internal set; } = null!;
    public List<Section> Sections { get; internal set; } = null!;
    public List<AsBuiltHoles> AsBuiltHoles { get; internal set; } = null!;
    public int PopulationAlertReceivers { get; internal set; }
    public DateTime? PopulationAlertSentDate { get; internal set; }
    public string BlasterName { get; internal set; } = null!;
    public int BlasterId { get; internal set; }
    public string BlasterEmploymentNumber { get; internal set; } = null!;
    public decimal MaxChargePerDelay { get; internal set; }
    public decimal? TunnelRoundArea { get; internal set; }
    public decimal? TunnelRoundLength { get; internal set; }
}