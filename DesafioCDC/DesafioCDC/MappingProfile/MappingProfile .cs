using AutoMapper;
using DesafioCDC.Entities;
using DesafioCDC.Requests;

namespace DesafioCDC.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AuthorRequest, Author>();
            CreateMap<CategoryRequest, Category>();
        }
    }
}
