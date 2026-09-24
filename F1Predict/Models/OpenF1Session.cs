using System.Text.Json.Serialization;

namespace F1Predict.Models
{
    internal class OpenF1Session
    {
        [JsonPropertyName("session_key")]
        public int SessionKey { get; set; }

        [JsonPropertyName("session_name")]
        public string SessionName { get; set; }

        [JsonPropertyName("meeting_key")]
        public int MeetingKey { get; set; }

        [JsonPropertyName("circuit_short_name")]
        public string CircuitShortName { get; set; }

        [JsonPropertyName("country_name")]
        public string CountryName { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("year")]
        public int Year { get; set; }
    }
}