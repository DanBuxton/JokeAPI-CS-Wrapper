using System.Text.Json.Serialization;

namespace JokeAPIWrapper.Models;

public abstract class JokeModel
{
    [JsonPropertyName("error")] public bool Error { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    [JsonPropertyName("category")] public string Category { private get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    public JokeCategory GetCategory() =>
        Enum.Parse<JokeCategory>(Category, true);

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    [JsonPropertyName("type")] public string Type { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    [JsonPropertyName("flags")] public IDictionary<string, bool> Flags { get; set; }
        = new Dictionary<string, bool>();

    [JsonPropertyName("id")] public int Id { get; set; }
    [JsonPropertyName("safe")] public bool Safe { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    [JsonPropertyName("lang")] public string Lang { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
}
