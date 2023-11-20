namespace Tests.Consts;

internal class Json
{
    internal const string GetMisfireJSON = """
                                          [
                                              {
                                                  "Id": 1,
                                                  "TimestampCreated": "2022-01-01T01:01:01.001",
                                                  "TimestampLastChanged": "2022-01-01T01:01:01.001",
                                                  "TimestampFound": "2022-01-01T01:01:01.001",
                                                  "ProjectId": 1,
                                                  "ProjectNumber": "1",
                                                  "ProjectName": "string",
                                                  "StatusId": 1,
                                                  "Status": "Aktiv",
                                                  "BlastId": 1,
                                                  "AmountExplosives": 1.0,
                                                  "AmountDetonators": null,
                                                  "AmountCords": null,
                                                  "AmountPrimers": null,
                                                  "Source": "string"
                                              }
                                          ]
                                          """;

    internal const string GetBlastJSON = """
                                         [    {
                                                 "Id": 1,
                                                 "ProjectId": 1,
                                                 "ProjectNumber": "string",
                                                 "ProjectName": "string",
                                                 "MethodStatementBlastingId": 1,
                                                 "Number": 1,
                                                 "Title": "Title",
                                                 "Type": "Type",
                                                 "BlastPlanCreated": "2022-01-01T01:01:01.001",
                                                 "BlastReportCreated": "2022-01-01T01:01:01.001",
                                                 "PlannedFired": "2022-01-01T00:00:00.000",
                                                 "ActualFired": "2022-01-01T00:00:00.000",
                                                 "LastChanged": "2022-01-01T00:00:00.000",
                                                 "RevisionNumber": 1,
                                                 "VolumePlan": 1.0,
                                                 "VolumeReport": 1.0,
                                                 "Latitude": 1.0,
                                                 "Longitude": 1.0,
                                                 "Norting": 1.0,
                                                 "Easting": 1.0,
                                                 "Epsg": "0",
                                                 "Z": 1.0,
                                                 "HolesPlan": 0,
                                                 "HolesReport": 0,
                                                 "ActualExplosives": 1.0,
                                                 "TheoreticalExplosives": 1.0,
                                                 "EstimatedMovementFront": null,
                                                 "EstimatedMovementBack": null,
                                                 "EstimatedMovementLeft": null,
                                                 "EstimatedMovementRight": null,
                                                 "ActualMovementFront": null,
                                                 "ActualMovementBack": null,
                                                 "ActualMovementLeft": null,
                                                 "ActualMovementRight": null,
                                                 "Contractor": "string",
                                                 "Products": [
                                                     {
                                                         "Id": 1,
                                                         "Name": "string",
                                                         "Classification": "string",
                                                         "Qty": 1.0,
                                                         "Unit": "kg",
                                                         "NetExplosives": 1.0
                                                     }
                                                 ],
                                                 "VibValues": [
                                                     {
                                                         "VibPointId": 1,
                                                         "CalculatedMaxValue": 1.0,
                                                         "Distance": 1.0,
                                                         "RockConstant": 1.0,
                                                         "MaxValue": 1.0,
                                                         "NewRockConstant": 1.0
                                                     }
                                                 ],
                                                 "Sections": [
                                                     {
                                                         "Type": "string",
                                                         "Spacing": 1.0,
                                                         "Burden": 1.0,
                                                         "HoleAngle": 1.0,
                                                         "Diameter": 1,
                                                         "Holes": 1,
                                                         "Rows": 1,
                                                         "TotalHoleDepth": 1.0
                                                     }
                                                 ],
                                                 "AsBuiltHoles": null,
                                                 "AsBuiltConcaveHullIdList": null,
                                                 "DirectionDegree": null,
                                                 "PopulationAlertReceivers": 0,
                                                 "PopulationAlertSentDate": null,
                                                 "BlasterName": "string",
                                                 "BlasterId": 1,
                                                 "BlasterEmploymentNumber": null,
                                                 "MaxChargePerDelay": 1.0,
                                                 "TunnelRoundArea": 1.0,
                                                 "TunnelRoundLength": 1.0
                                             }]
                                         """;

    internal const string GetProjectsJSON = """
                                            [
                                                {
                                                    "Id": 1,
                                                    "ProjectNumber": "string",
                                                    "ProjectName": "string",
                                                    "VibPointList": [
                                                        {
                                                            "Id": 2,
                                                            "ProviderName": "string",
                                                            "Name": "string",
                                                            "Placement": "string",
                                                            "ActivationDate": "2022-01-01T01:01:01.001",
                                                            "DeactivationDate": null,
                                                            "Instrument": "",
                                                            "IsActive": true,
                                                            "Latitude": null,
                                                            "Longitude": null,
                                                            "Z": null,
                                                            "Norting": null,
                                                            "Easting": null,
                                                            "Epsg": "0",
                                                            "Limit": 0,
                                                            "LimitComment": "",
                                                            "Created": "2022-01-01T01:01:01.001"
                                                        }
                                                    ],
                                                    "MethodStatementBlastingList": [
                                                        {
                                                            "Id": 3,
                                                            "LastPublished": "2022-01-01T01:01:01.001",
                                                            "LastRevision": 1,
                                                            "Title": "Title",
                                                            "Polygon": [
                                                                {
                                                                    "Latitude": 0.0,
                                                                    "Longitude": 0.0
                                                                }
                                                            ]
                                                        }
                                                    ]
                                                }
                                            ]
                                            """;
}