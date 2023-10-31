namespace JokeAPIWrapper;

public sealed class Request : IRequest
{
    internal string? Endpoint { get; set; }
    internal Dictionary<string, string> Params { get; private set; } = new();
    internal bool SafeMode { get; set; }

    public string GetUri()
    {
        string uri = Endpoint ?? "Any";

        if (Params.Count > 0)
        {
            IEnumerable<string> parameters = Params.Select(p => $"{p.Key}={p.Value}");

            uri += "?" + string.Join('&', parameters);
        }

        if (!SafeMode)
        {
            return uri;
        }

        return uri + (Params.Count > 0 ? "&" : "?") + "safe-mode";
    }
}
