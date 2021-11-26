using AutoMapper;
using JOBProfile.Commands;
using JOBProfile.Responses;

namespace JOBProfile.Mappers
{
    public class RecipyMappingProfile:Profile
    {
        public RecipyMappingProfile()
        {
            CreateMap<JOBProfile.Core.Entities.Recipies, RecipiesResponse> ().ReverseMap();
            CreateMap<JOBProfile.Core.Entities.Recipies, CreateRecipiesCommand> ().ReverseMap();
        }
    }
}
