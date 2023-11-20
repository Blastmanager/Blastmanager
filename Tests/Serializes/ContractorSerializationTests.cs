using System.Text.Json;
using Blastmanager.Contractor.Entities.Response;
using Tests.Consts;

namespace Tests.Serializes;

public class ContractorSerializationTests
{
    [Fact]
    public void DeSerializeGetProjects()
    {
        // Act
        var deserialize = JsonSerializer.Deserialize<GetProjectsResponse[]>(Json.GetProjectsJSON);
        // Assert
        Assert.NotNull(deserialize);
    }

    [Fact]
    public void DeSerializeGetMisfires()
    {
        // Act
        var deserialize = JsonSerializer.Deserialize<GetMisfireResponse[]>(Json.GetMisfireJSON);
        // Assert
        Assert.NotNull(deserialize);
    }

    [Fact]
    public void DeSerializeGetBlasts()
    {
        // Act
        var deserialize = JsonSerializer.Deserialize<BlastReportsResponse[]>(Json.GetBlastJSON);
        // Assert
        Assert.NotNull(deserialize);
    }
}