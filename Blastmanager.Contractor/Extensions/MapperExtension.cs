using Blastmanager.Contractor.Entities;
using Blastmanager.Contractor.Entities.Response;

namespace Blastmanager.Contractor.Extensions;

internal static class MapperExtension
{
    internal static BlastReport[]? ToBlastReports(this BlastReportsResponse[]? b)
    {
        if (b is null || b.Length == 0) return null;
        var result = new BlastReport[b.Length];
        for (var i = 0; i < b.Length; i++) result[i] = b[i].ToBlastReport();

        return result;
    }

    internal static BlastReport ToBlastReport(this BlastReportsResponse b)
        => new()
        {
                Id = b.Id,
                ProjectId = b.ProjectId,
                ProjectName = b.ProjectName,
                ProjectNumber = b.ProjectNumber,
                Number = b.Number,
                Title = b.Title,
                Contractor = b.Contractor,
                Type = b.Type,
                BlastPlanCreated = b.BlastPlanCreated,
                BlastReportCreated = b.BlastReportCreated,
                PlannedFire = b.PlannedFire,
                ActualFired = b.ActualFired,
                LastChanged = b.LastChanged,
                RevisionNumber = b.RevisionNumber,
                Volume = new() { Plan = b.VolumePlan, Report = b.VolumeReport },
                HolesPlan = b.HolesPlan,
                HolesReport = b.HolesReport,
                Drill = new()
                {
                        MetersPlan = b.DrillmetersPlan,
                        MetersReport = b.DrillmetersReport,
                        Actual = b.ActualDrillmeters
                },
                Explosives = new()
                {
                        Actual = b.ActualExplosives,
                        TheoreticalPlan = b.TheoreticalExplosivesPlan,
                        TheoreticalReport = b.TheoreticalExplosivesReport
                },
                Movements = new()
                {
                        Actual = new()
                        {
                                Back = b.ActualMovementBack,
                                Front = b.ActualMovementFront,
                                Left = b.ActualMovementLeft,
                                Right = b.ActualMovementRight
                        },
                        Estimated = new()
                        {
                                Back = b.EstimatedMovementBack,
                                Front = b.EstimatedMovementFront,
                                Left = b.EstimatedMovementLeft,
                                Right = b.EstimatedMovementRight
                        }
                },
                MethodStatementBlastingId = b.MethodStatementBlastingId,
                AsBuiltConcaveHullIdList = b.AsBuiltConcaveHullIdList,
                DirectionDegree = b.DirectionDegree,
                Products = b.Products,
                VibValues = b.VibValues,
                Sections = b.Sections,
                AsBuiltHoles = b.AsBuiltHoles,
                PopulationAlertReceivers = b.PopulationAlertReceivers,
                PopulationAlertSentDate = b.PopulationAlertSentDate,
                Blaster = new()
                {
                        Id = b.BlasterId,
                        Name = b.BlasterName,
                        EmploymentNumber = b.BlasterEmploymentNumber
                },
                MaxChargePerDelay = b.MaxChargePerDelay,
                TunnelRoundArea = b.TunnelRoundArea,
                TunnelRoundLength = b.TunnelRoundLength,
                Coordinates = new()
                {
                        Latitude = b.Latitude,
                        Longitude = b.Longitude,
                        Easting = b.Easting,
                        Epsg = b.Epsg,
                        Northing = b.Northing,
                        Z = b.Z
                },
                AreaPlan = b.AreaPlan,
                AreaReport = b.AreaReport
        };

    internal static Project ToProject(this GetProjectsResponse b)
        => new()
        {
                Id = b.Id,
                ProjectName = b.ProjectName,
                ProjectNumber = b.ProjectNumber,
                VibPointList = b.VibPointList,
                MethodStatementBlastingList = b.MethodStatementBlastingList
        };

    internal static Project[]? ToProjects(this GetProjectsResponse[]? b)
    {
        if (b is null || b.Length == 0) return null;
        var result = new Project[b.Length];
        for (var i = 0; i < b.Length; i++) result[i] = b[i].ToProject();

        return result;
    }

    internal static Misfire ToMisfire(this GetMisfireResponse b) => new()
    {
            Id = b.Id,
            ProjectId = b.ProjectId,
            ProjectName = b.ProjectName,
            ProjectNumber = b.ProjectNumber,
            Source = b.Source,
            Status = b.Status,
            AmountCord = b.AmountCord,
            AmountDetonators = b.AmountDetonators,
            AmountExplosives = b.AmountExplosives,
            AmountPrimers = b.AmountPrimers,
            BlastId = b.BlastId,
            StatusId = b.StatusId,
            TimestampCreated = b.TimestampCreated,
            TimestampFound = b.TimestampFound,
            TimestampLastChanged = b.TimestampLastChanged,
            Easting = b.Easting,
            Northing = b.Northing,
            Comment = b.Comment,
            MisfireContent = b.MisfireContent,
            ReasonText = b.ReasonText,
            FixedHowText = b.FixedHowText,
            FixedHow = b.FixedHow,
            Primer = b.Primer,
            BlastType = b.BlastType,
            DetonatorType = b.DetonatorType,
            ExplosiveTypes = b.ExplosiveTypes,
            FoundHow = b.FoundHow,
            PotentialReasons = b.PotentialReasons,
            ReportedAuthority = b.ReportedAuthority
    };

    internal static Misfire[]? ToMisfires(this GetMisfireResponse[]? b)
    {
        if (b is null || b.Length == 0) return null;
        var result = new Misfire[b.Length];
        for (var i = 0; i < b.Length; i++) result[i] = b[i].ToMisfire();

        return result;
    }
}