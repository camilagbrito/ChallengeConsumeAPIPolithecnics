using AutoMapper;
using ChallengeConsumeAPI.Dtos;
using ChallengeConsumeAPI.Models;

namespace ChallengeConsumeAPI.AutoMapper
{
    public class AutoMapperConfig: Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<InstituteDto, Institute>().ReverseMap().ForMember(
                dest => dest.WebPages, opt => opt.MapFrom(url => url.WebPages.FirstOrDefault()));
        }
    }
}
