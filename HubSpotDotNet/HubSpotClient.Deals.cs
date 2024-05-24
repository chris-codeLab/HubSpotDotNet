using System.Globalization;
using System.Text.Json;
using HubSpotDotNet.Extensions;
using HubSpotDotNet.Models;

namespace HubSpotDotNet;

public partial class HubSpotClient
{
    public async Task<SearchResponse> SearchAllAsync(SearchRequest request, CancellationToken cancellationToken = default)
    {
        int? total = null;
        List<HubSpotResult> results = [];
        string? after = null;
        do
        {
            request.After = after;
            SearchResponse response = await SearchAsync(request, cancellationToken);
            total ??= response.Total;
            after = response.Paging?.Next?.After;
            results.AddRange(response.Results);
        } while (!string.IsNullOrWhiteSpace(after));

        return new SearchResponse
        {
            Total = total.Value,
            Results = results.ToArray()
        };
    }

    public async Task<T[]> SearchAsync<T>(SearchRequest request, CancellationToken cancellationToken = default) where T : HubSpotResult
    {
        var searchResponse = await SearchAsync(request, cancellationToken);
        List<T> result = [];
        foreach (HubSpotResult hubSpotResult in searchResponse.Results)
        {
            //todo - create T via reflection
        }

        return result.ToArray();
    }

    public async Task<SearchResponse> SearchAsync(SearchRequest request, CancellationToken cancellationToken = default)
    {
        var body = JsonSerializer.Serialize(request);
        return await Post<SearchResponse>($"crm/v3/objects/{request.ObjectType.GetHubspotObjectType().UrlPathName}/search", body, cancellationToken);
    }
}