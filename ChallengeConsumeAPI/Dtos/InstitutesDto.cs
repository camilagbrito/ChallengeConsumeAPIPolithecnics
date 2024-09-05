using System.Dynamic;
using System.Net;

namespace ChallengeConsumeAPI.Dtos
{

    public class InstitutesDto
    {
        public List<InstituteDto> Institutes { get; set; }
        public int TotalCount { get; set; }
    }
}
