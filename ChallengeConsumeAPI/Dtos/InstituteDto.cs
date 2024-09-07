using System.Text.Json.Serialization;

namespace ChallengeConsumeAPI.Dtos
{
    public class InstituteDto
    {
        [JsonPropertyName("Name")]
        public string? Name { get; set; }

        [JsonPropertyName("Webpage")]
        public string WebPages{ get; set; }

    }
}
