using AutoMapper;
using WebApplication.DAL.Models;
using WebApplication.DTOs;

namespace WebApplication.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Author, GetAuthorDTO>()
                .ForMember(dest => dest.Id, o => o.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, o => o.MapFrom(src => src.Name));

            CreateMap<Agency, GetAgencyDTO>()
                .ForMember(dest => dest.Id, o => o.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, o => o.MapFrom(src => src.Name));

            CreateMap<Book, GetBookDTO>()
                .ForMember(dest => dest.AgencyId, o => o.MapFrom(src => src.AgencyId))
                .ForMember(dest => dest.AuthorId, o => o.MapFrom(src => src.AuthorId))
                .ForMember(dest => dest.Title, o => o.MapFrom(src => src.Title))
                .ForMember(dest => dest.Language, o => o.MapFrom(src => src.Language))
                .ForMember(dest => dest.Pages, o => o.MapFrom(src => src.Pages));
        }
    }
}