using System.Text.Json.Serialization;

namespace JokeAPIWrapper.Models;

public abstract class JokeModel
{
    [JsonPropertyName("error")] public bool Error { get; set; }

    [JsonPropertyName("category")] public string? Category { private get; set; }

    public JokeCategory GetCategory() =>
        Enum.Parse<JokeCategory>(Category ?? "any", true);

    [JsonPropertyName("type")] public string? Type { get; set; }

    [JsonPropertyName("flags")] public IDictionary<string, bool> Flags { get; set; }
        = new Dictionary<string, bool>();

    [JsonPropertyName("id")] public int Id { get; set; }
    [JsonPropertyName("safe")] public bool Safe { get; set; }
    [JsonPropertyName("lang")] public string? Lang { get; set; }
}
