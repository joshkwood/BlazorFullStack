using AutoMapper;
using BlazorResearchTool.Server.Dto;
using BlazorResearchTool.Shared;

namespace BlazorResearchTool.Server.Helpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Author, AuthorDto>();
        CreateMap<AuthorDto, Author>();

    }
    
}