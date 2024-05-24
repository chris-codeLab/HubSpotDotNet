using Microsoft.Extensions.Configuration;

namespace HubSpotDotNet.Tests;

public abstract class TestBase
{
    public readonly HubSpotClient HudSpotClient;

    protected TestBase()
    {
        HudSpotClient = GetClient();
    }

    private HubSpotClient GetClient()
    {
        try
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<TestBase>()
                .Build();

            var accessToken = config["AccessToken"];
            return new HubSpotClient(accessToken);
        }
        catch (Exception)
        {
            throw new Exception("In order to run Unit-tests you need to add a user secrets 'AccessToken' (string). See more here: https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-7.0&tabs=windows#manage-user-secrets-with-visual-studio");
        }
    }
}