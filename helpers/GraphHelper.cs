using Azure.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Graph;

public static class GraphHelper
{
  public static GraphServiceClient GetGraphClient()
  {
    var Config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
    var ApplicationId = Config.GetSection("AppSettings")["applicationId"];
    var scopes = new[] { "ServiceHealth.Read.All" };

    var interactiveBrowserCredentialOptions = new InteractiveBrowserCredentialOptions
    {
      ClientId = ApplicationId
    };

    var tokenCredential = new InteractiveBrowserCredential(interactiveBrowserCredentialOptions);
    var graphClient = new GraphServiceClient(tokenCredential, scopes);
    return graphClient;
  }
}