using System.Text.Json.Serialization;

namespace ChallengeConsumeAPI.Dtos
{
    public class InstituteDto
    {
        public string? Name { get; set; }

        [JsonPropertyName("Webpage")]
        public List<string>? WebPages{ get; set; }

    }
}
