using Xunit.Sdk;

namespace JokeAPIWrapper.Tests;

public class ApiClientTests
{
    internal readonly ApiClientV2 _client;
    public ApiClientTests()
    {
        _client = new ApiClientV2(new HttpClient());
    }

    [Fact]
    public async Task GetJokeAnyCategoryAsyncTest()
    {
        var builder = new RequestBuilder();

        var joke = await _client.GetJokeAsync(builder);

        Assert.NotNull(joke);
        Assert.False(joke.Error);
    }
    [Theory]
    [InlineData(JokeCategory.Spooky)]
    [InlineData(JokeCategory.Misc)]
    [InlineData(JokeCategory.Programming)]
    [InlineData(JokeCategory.Pun)]
    [InlineData(JokeCategory.Dark)]
    public async Task GetJokeCategoryAsyncTest(JokeCategory targetCategory)
    {
        IRequestBuilder builder = new RequestBuilder();
        builder.WithCategory(targetCategory);

        var joke = await _client.GetJokeAsync(builder);

        Assert.Equal(joke!.GetCategory(), targetCategory);
        Assert.False(joke.Error);
    }

    [Theory]
    [InlineData(JokeLanguage.EN)]
    [InlineData(JokeLanguage.PT)]
    [InlineData(JokeLanguage.FR)]
    [InlineData(JokeLanguage.DE)]
    [InlineData(JokeLanguage.ES)]
    [InlineData(JokeLanguage.CS)]
    public async Task GetJokeAltLanguageAsyncTest(JokeLanguage targetLanguage)
    {
        IRequestBuilder builder = new RequestBuilder();
        builder.WithLanguage(targetLanguage);

        var joke = await _client.GetJokeAsync(builder);

        Assert.Equal(joke!.Lang, targetLanguage.ToString().ToLower());
        Assert.False(joke.Error);
    }

    [Theory]
    [InlineData(JokeCategory.Spooky, JokeCategory.Programming, JokeCategory.Misc)]
    [InlineData(JokeCategory.Programming, JokeCategory.Pun, JokeCategory.Dark)]
    public async Task GetJokeMultiCategoryTest(params JokeCategory[] targetCategories)
    {
        IRequestBuilder builder = new RequestBuilder();
        builder.WithCategories(targetCategories);

        var joke = await _client.GetJokeAsync(builder);
        var cat = joke!.GetCategory();

        Assert.Contains(cat, targetCategories);
        Assert.False(joke.Error);
    }
}