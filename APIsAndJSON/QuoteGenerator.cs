using Newtonsoft.Json.Linq;

namespace APIsAndJSON;

public class QuoteGenerator
{
    private HttpClient _client;

    public QuoteGenerator(HttpClient client)
    {
        _client = client;
    }
    public string KanyeQuote()
    {
        var client = new HttpClient();

        var kanyeURL = "https://api.kanye.rest";

        var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

        var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

        return kanyeQuote;
    }

    public string RonSwansonQuote()
    {
        var client = new HttpClient();

        var ronSwansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
        
        var ronResponse = client.GetStringAsync(ronSwansonURL).Result;

        var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

        return ronQuote;
    }
}