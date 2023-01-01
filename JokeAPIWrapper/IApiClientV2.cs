using JokeAPIWrapper.Models;

namespace JokeAPIWrapper
{
    public interface IApiClientV2
    {
        JokeModel GetJoke(JokeCategory? jokeCategory = null);
        Task<JokeModel> GetJokeAsync(JokeCategory? jokeCategory = null);
    }
}