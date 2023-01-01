using System.Text.Json.Serialization;

namespace JokeAPIWrapper.Models;

public sealed class SingleJokeModel : JokeModel
{
    [JsonPropertyName("joke")] public string? Joke { get; set; }
}
