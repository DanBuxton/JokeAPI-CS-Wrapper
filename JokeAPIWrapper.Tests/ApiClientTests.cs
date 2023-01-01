using Xunit.Sdk;

namespace JokeAPIWrapper.Tests;

public class ApiClientTests
{
    private readonly ApiClientV2 _client;
    public ApiClientTests()
    {
        _client = new ApiClientV2(new HttpClient());
    }

    [Theory]
    [InlineData(JokeCategory.Spooky)]
    [InlineData(JokeCategory.Misc)]
    [InlineData(JokeCategory.Programming)]
    [InlineData(JokeCategory.Pun)]
    [InlineData(JokeCategory.Dark)]
    public async Task GetJokeCategoryTest(JokeCategory targetCategory)
    {
        var joke = await _client.GetJokeAsync(targetCategory);

        Assert.Equal(joke!.GetCategory(), targetCategory);
    }

    [Fact]
    public async Task GetJokeAnyCategoryAsyncTest()
    {
        var joke = await _client.GetJokeAsync();

        Assert.NotNull(joke);
        Assert.False(joke.Error);
    }

    [Fact]
    public void GetJokeAnyCategoryTest()
    {
        var joke = _client.GetJoke();

        Assert.NotNull(joke);
        Assert.False(joke.Error);
    }
}