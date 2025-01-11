using JokeAPIWrapper.Models;

namespace JokeAPIWrapper;

public interface IApiClientV2
{
    JokeModel GetJoke(IRequestBuilder request);

    Task<JokeModel> GetJokeAsync(IRequestBuilder request);
}