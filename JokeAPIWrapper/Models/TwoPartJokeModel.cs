using System.Text.Json.Serialization;

namespace JokeAPIWrapper.Models;

public sealed class TwoPartJokeModel : JokeModel
{
    [JsonPropertyName("setup")] public string? Setup { get; set; }
    [JsonPropertyName("delivery")] public string? Delivery { get; set; }
}
