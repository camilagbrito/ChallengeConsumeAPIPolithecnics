using ChallengeConsumeAPI.Models;

namespace ChallengeConsumeAPI.Interfaces
{
    public interface IHipolabsService
    {

      Task<List<Institute>> GetPolytechnics();
  
    }
}
