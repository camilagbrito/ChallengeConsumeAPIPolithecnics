using ChallengeConsumeAPI.Dtos;
using ChallengeConsumeAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace ChallengeConsumeAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InstituteController : ControllerBase
    {
        public readonly IInstituteService _instituteService;

        public InstituteController(IInstituteService instituteService)
        {
            _instituteService = instituteService;
        }

        [HttpGet("GetPolytechnics")]
        public async Task<IActionResult> GetPolytechnics()
        {
           var institutes = await _instituteService.GetPolytechnics();
  
            return Ok(institutes);
        }



        [HttpGet("GetPolytechnicsOrderedByName")]
        public async Task<IActionResult> GetPolytechnicsOrderedByName(bool isAscending)
        {
            var politechnics = await _instituteService.GetPolytechnics(); 

            var institutes = await _instituteService.OrderByName(politechnics.Institutes, isAscending);

            return Ok(institutes);
        }



    }
}