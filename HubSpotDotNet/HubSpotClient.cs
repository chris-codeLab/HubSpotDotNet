using System.Net.Http.Headers;
using System.Text.Json;
using System.Text;

namespace HubSpotDotNet;

public partial class HubSpotClient
{
    private readonly HttpClient _httpClient = new();
    private readonly string _accessToken;

    public HubSpotClient(string accessToken, HubSpotClientOptions? hubSpotClientOptions = null)
    {
        if (string.IsNullOrWhiteSpace(accessToken))
        {
            throw new HubSpotClientException("No Access Token provided");
        }

        _accessToken = accessToken;
        if (hubSpotClientOptions?.HttpClient != null)
        {
            _httpClient = hubSpotClientOptions.HttpClient;
        }
    }

    public async Task<T> Get<T>(string suffix, CancellationToken cancellationToken = default)
    {
        //Todo - Exception handling
        var json = await GetRawJson(suffix, cancellationToken);
        return JsonSerializer.Deserialize<T>(json)!;
    }

    public async Task<T> Post<T>(string suffix, string body, CancellationToken cancellationToken = default)
    {
        //todo - error handling
        var json = await PostRaw(suffix, body, cancellationToken);
        return JsonSerializer.Deserialize<T>(json)!;
    }

    public async Task<string> PostRaw(string suffix, string body, CancellationToken cancellationToken = default)
    {
        //Todo - Exception handling
        string url = PrepConnectionAndUrl(ref suffix);
        HttpResponseMessage response = await _httpClient.PostAsync(url, new StringContent(body, Encoding.UTF8, "application/json"), cancellationToken);
        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    private async Task<string> GetRawJson(string suffix, CancellationToken cancellationToken = default)
    {
        string url = PrepConnectionAndUrl(ref suffix);
        return await _httpClient.GetStringAsync(url, cancellationToken);
    }

    private string PrepConnectionAndUrl(ref string suffix)
    {
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);
        if (!suffix.StartsWith('/'))
        {
            suffix = $"/{suffix}";
        }

        return "https://api.hubapi.com" + suffix;
    }
}