using JokeAPIWrapper.Models;

namespace JokeAPIWrapper;

public interface IApiClientV2
{
    [Obsolete("Use IRequestBuilder instead")] JokeModel GetJoke(JokeCategory? jokeCategory = null);
    [Obsolete("Use IRequestBuilder instead")] JokeModel GetJoke(params JokeCategory[] jokeCategories);
    JokeModel GetJoke(IRequestBuilder request);

    [Obsolete("Use IRequestBuilder instead")] Task<JokeModel> GetJokeAsync(JokeCategory? jokeCategory = null);
    [Obsolete("Use IRequestBuilder instead")] Task<JokeModel> GetJokeAsync(params JokeCategory[] jokeCategories);
    Task<JokeModel> GetJokeAsync(IRequestBuilder request);
}