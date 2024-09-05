using AutoMapper;
using ChallengeConsumeAPI.Dtos;
using ChallengeConsumeAPI.Interfaces;


namespace ChallengeConsumeAPI.Services
{
    public class InstituteService : IInstituteService
    {

        private readonly IMapper _mapper;
        private readonly IHipolabsService _hipolabsService;

        public InstituteService(IMapper mapper, IHipolabsService hipolabsService)
        {
            _mapper = mapper;
            _hipolabsService = hipolabsService;
        }

        public async Task<InstitutesDto> GetPolytechnics()
        {
            var institutes = await _hipolabsService.GetPolytechnics();


            var response = _mapper.Map <List<InstituteDto>>(institutes);

            var totalCount = await GetTotalCount(response);

            var institutesDto = new InstitutesDto();

            institutesDto.Institutes = response;

            institutesDto.TotalCount = totalCount;

            return institutesDto;
        }

        public async Task<int> GetTotalCount(List<InstituteDto> institutes)
        {
            var totalCount = institutes.Count();

            return totalCount;
        }

        public async Task<List<InstituteDto>> OrderByName(List<InstituteDto> institutes, bool isAscending)
        {
            if (isAscending == true)
            {
                var ascending =  institutes.OrderBy(x => x.Name);
                return ascending.ToList();

            }
            else
            {
                var descending = institutes.OrderByDescending(x => x.Name);
                return descending.ToList();
            }
        }

    }
}
