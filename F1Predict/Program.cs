using System.Net.Http;
using System.Text.Json;
using F1Predict.Models;

internal class Program
{
    private static async Task Main(string[] args)
    {
        HttpClient client = new HttpClient();

        string url =
            "https://api.openf1.org/v1/sessions?country_name=Monaco&session_name=Race&year=2025";

        string json = await client.GetStringAsync(url);

        Console.WriteLine(json);

        List<OpenF1Session> sessions = JsonSerializer.Deserialize<List<OpenF1Session>>(json);

        OpenF1Session session = sessions[0];

        Console.WriteLine("Circuit : " + session.CircuitShortName);
        Console.WriteLine("Pays : " + session.CountryName);
        Console.WriteLine("Session key : " + session.SessionKey);

        string urlResults = "https://api.openf1.org/v1/session_result?session_key=9979";

        string jsonResults = await client.GetStringAsync(urlResults);

        Console.WriteLine(jsonResults);
    }
}