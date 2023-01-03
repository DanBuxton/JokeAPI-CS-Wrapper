using JokeAPIWrapper.Models;

namespace JokeAPIWrapper;

internal interface IRequestBuilder
{
    IRequest Build();
    IRequestBuilder WithBlacklistFlags(params string[] flags);
    IRequestBuilder WithCategories(JokeCategory[] categories);
    IRequestBuilder WithCategory(JokeCategory? category);
    IRequestBuilder WithLanguage(string lang);
    IRequestBuilder WithSafeMode(bool safeMode = true);
    IRequestBuilder WithSearch(string str);
    IRequestBuilder WithType(bool? single);
}
