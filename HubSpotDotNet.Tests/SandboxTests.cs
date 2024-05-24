using System.Text.Json.Serialization;
using HubSpotDotNet.Models;
using HubSpotDotNet.Models.Associations;

namespace HubSpotDotNet.Tests;

public class SandboxTests : TestBase
{
    [Fact]
    public async Task Foo()
    {
        var request = new GetAssociationsRequest(HubSpotObjectType.Company, HubSpotObjectType.Deal, ["9477862393"]);
        var response = await HudSpotClient.GetAssociationsAsync(request);
    }

    [Fact]
    public async Task Foo2()
    {
        var request = new SearchRequest
        {
            ObjectType = HubSpotObjectType.Deal,
            Properties = ["dealName", "dealStage"],
            Limit = 1,
            FilterGroups =
            [
                new SearchRequestFilterGroup
                {
                    Filters =
                    [
                        new SearchRequestFilter
                        {
                            PropertyName = "pipeline",
                            Operator = "EQ",
                            Value = "default"
                        }
                    ]
                }
            ]
        };
        var responseAll = await HudSpotClient.SearchAsync<Deal>(request);
    }
}

public class Deal : HubSpotResult
{
    [JsonPropertyName("dealName")] public string Name { get; set; }
    [JsonPropertyName("dealStage")] public string Stage { get; set; }
}