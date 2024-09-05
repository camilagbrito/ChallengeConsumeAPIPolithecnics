using ChallengeConsumeAPI.Dtos;


namespace ChallengeConsumeAPI.Interfaces
{
    public interface IInstituteService
    {
        Task<InstitutesDto> GetPolytechnics();
        Task<int> GetTotalCount(List<InstituteDto> institutes);
        Task<List<InstituteDto>> OrderByName(List<InstituteDto> institutes, bool isAscending);

    }
}
