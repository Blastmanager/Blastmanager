namespace Blastmanager.Contractor.Entities.Constants;

internal static class ApiUri
{
    public const string BaseUri = "https://external.blastmanager.no/";

    public const string GetProjects = "api/contractor/GetProjects";
    public const string GetBlastReportsByBlastDate = "api/contractor/GetBlastReportsByBlastDate";
    public const string GetBlastReportsByLastChanged = "api/contractor/GetBlastReportsByLastChanged";
    public const string GetMisFiresByLastChanged = "api/contractor/GetMisfiresByLastChanged";
    public const string GetMisFiresByFoundDate = "api/contractor/GetMisfiresByFoundDate";
}