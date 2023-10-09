using JokeAPIWrapper.Models;
using System.Text.Json;

namespace JokeAPIWrapper;

public sealed class ApiClientV2 : IApiClientV2
{
    private static readonly Exception _apiError = new("Api error. Please see if https://v2.jokeapi.dev is still available and working");
    private static readonly Exception _myCodeError = new("My code is broke! Please help by going to https://github.com/DanBuxton/JokeAPI-CS-Wrapper");
    private readonly HttpClient _client;

    public ApiClientV2(HttpClient client)
    {
        _client = client;
    }
    public ApiClientV2()
    {
        _client = new HttpClient();
    }

    private async Task<JokeModel> GetApiResponse(IRequest request)
    {
        // Create a valid uri
        const string baseUri = "https://v2.jokeapi.dev/joke/";

        // Send a get request
        var response = await _client.GetAsync(baseUri + request.GetUri());

        // Check the response for errors
        if (response is null || !response.IsSuccessStatusCode)
        {
            throw _apiError;
        }

        // Turn the response into a JSON object
        var json = await JsonSerializer.DeserializeAsync<JsonElement>(await response.Content.ReadAsStreamAsync());

        // Handle API error response
        if (json.GetProperty("error").GetBoolean())
        {
            HandleError(json);
        }

        return BuildJoke(json);
    }
    private static JokeModel BuildJoke(JsonElement json)
    {
        try
        {
            // JSON property not found in a twopart joke
            json.GetProperty("joke");

            return json.Deserialize<SingleJokeModel>()!;
        }
        catch (KeyNotFoundException)
        {
            return json.Deserialize<TwoPartJokeModel>()!;
        }
    }
    private static void HandleError(JsonElement json)
    {
        var error = json.Deserialize<ErrorModel>()!;

        if (error.InternalError)
        {
            throw _apiError;
        }

        throw _myCodeError;
    }

    public async Task<JokeModel> GetJokeAsync(JokeCategory? jokeCategory = null)
    {
        RequestBuilder b = new();

        b.WithCategory(jokeCategory);

        return await GetApiResponse(b.Build());
    }
    public async Task<JokeModel> GetJokeAsync(params JokeCategory[] jokeCategories)
    {
        RequestBuilder b = new();

        b.WithCategories(jokeCategories);

        return await GetApiResponse(b.Build());
    }
    public JokeModel GetJoke(JokeCategory? jokeCategory = null)
    {
        var req = GetJokeAsync(jokeCategory);

        req.Wait();

        return req.Result;
    }
}
