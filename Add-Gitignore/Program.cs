using CommandLine;
using RestSharp;

namespace Add_Gitignore;

public class Program
{
    private const string FILENAME = ".gitignore"; 
    
    private static readonly RestClient client = new RestClient("https://www.toptal.com/developers/gitignore/api/");
    
    public static async Task Main(string[] args)
    {
        await Parser
            .Default.ParseArguments<Options>(args)
            .WithParsedAsync(options => Run(options));
    }

    private static async Task Run(Options options)
    {
        var request = new RestRequest(string.Join(",", options.Ignore));
        var response = await client.ExecuteAsync(request);
        await File.WriteAllTextAsync(FILENAME, response.Content);
    }
}




