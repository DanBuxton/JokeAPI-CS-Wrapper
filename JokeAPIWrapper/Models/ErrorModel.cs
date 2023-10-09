using System.Text.Json.Serialization;

namespace JokeAPIWrapper.Models;

public sealed class ErrorModel
{
    [JsonPropertyName("error")] public bool Error { get; set; }
    [JsonPropertyName("internalError")] public bool InternalError { get; set; }
    [JsonPropertyName("code")] public int Code { get; set; }
    [JsonPropertyName("messaage")] public string? Message { get; set; }
    [JsonPropertyName("cauedBy")] public string[]? CausedBy { get; set; }
    [JsonPropertyName("additionalInfo")] public string? AdditionalInfo { get; set; }

    [JsonPropertyName("timestamp")] public DateTime Timestamp { get; set; }
}
