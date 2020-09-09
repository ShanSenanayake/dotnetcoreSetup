
// Lat: 56.072399
// Long: 14.357470

using System.Net.Http;
using System.Threading.Tasks;

public class YrIntegration
{
    private readonly IHttpClientFactory _clientFactory;
    private readonly string URL = "https://api.met.no/weatherapi/locationforecast/2.0/compact?lat=56.072399&lon=14.357470";

    public YrIntegration(IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory;
    }

    public async Task GetWeather()
    {
        try
        {
            var request = new HttpRequestMessage(HttpMethod.Get, URL);
            request.Headers.Add("User-Agent", "shans-weather-app");
            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            System.Console.WriteLine(result);
        }
        catch (System.Exception exception)
        {
            System.Console.WriteLine(exception);
        }

    }
}