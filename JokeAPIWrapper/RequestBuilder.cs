using JokeAPIWrapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokeAPIWrapper;

public sealed class RequestBuilder : IRequestBuilder
{
    private readonly Request _request = new();

    public IRequestBuilder WithCategory(JokeCategory? category)
    {
        _request.Endpoint = category?.ToString() ?? "Any";

        return this;
    }
    public IRequestBuilder WithCategories(JokeCategory[] categories)
    {
        _request.Endpoint = string.Join(',', categories) ?? "Any";

        return this;
    }

    public IRequestBuilder WithLanguage(JokeLanguage lang = JokeLanguage.EN)
    {
        _request.Params.Add("lang", lang.ToString().ToLower());

        return this;
    }

    public IRequestBuilder WithBlacklistFlags(params string[] flags)
    {
        _request.Params.Remove("blacklist");

        _request.Params.Add("blacklist", string.Join(',', flags));

        return this;
    }

    public IRequestBuilder WithSearch(string str)
    {
        if (str == "")
        {
            _request.Params.Remove("contains");
        }
        else
        {
            _request.Params.Add("contains", str);
        }

        return this;
    }

    public IRequestBuilder WithType(bool? single)
    {
        if (!single.HasValue)
        {
            _request.Params.Remove("type");

            return this;
        }

        if (single.Value)
        {
            _request.Params.Add("type", "single");
        }
        else
        {
            _request.Params.Add("type", "twopart");
        }

        return this;
    }

    public IRequestBuilder WithSafeMode(bool safeMode = true)
    {
        _request.SafeMode = safeMode;

        return this;
    }

    public IRequest Build()
    {
        return _request;
    }
}
