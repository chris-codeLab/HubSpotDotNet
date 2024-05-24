using System.Text.Json;
using HubSpotDotNet.Extensions;
using HubSpotDotNet.Models;
using HubSpotDotNet.Models.Associations;

namespace HubSpotDotNet;

public partial class HubSpotClient
{
    public async Task<AssociationResponse> GetAssociationsAsync(GetAssociationsRequest request, CancellationToken cancellationToken = default)
    {
        var body = JsonSerializer.Serialize(new IdInputsRequest
        {
            Inputs = request.FromObjectIds.Select(x => new IdInput { Id = x }).ToArray()
        });
        return await Post<AssociationResponse>($"crm/v4/associations/{request.FromObject.GetHubspotObjectType().AssociationName}/{request.ToObject.GetHubspotObjectType().AssociationName}/batch/read", body, cancellationToken);
    }
}