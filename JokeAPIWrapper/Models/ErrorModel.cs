using System.Text.Json.Serialization;

namespace JokeAPIWrapper.Models;

public sealed class ErrorModel
{
    [JsonPropertyName("error")] public bool Error { get; set; }
    [JsonPropertyName("internalError")] public bool InternalError { get; set; }
    [JsonPropertyName("code")] public int Code { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    [JsonPropertyName("messaage")] public string Message { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    [JsonPropertyName("cauedBy")] public string[] CausedBy { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    [JsonPropertyName("additionalInfo")] public string AdditionalInfo { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    [JsonPropertyName("timestamp")] public DateTime Timestamp { get; set; }
}
