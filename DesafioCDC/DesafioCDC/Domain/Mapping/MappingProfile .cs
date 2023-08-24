using AutoMapper;
using DesafioCDC.Domain.Entities;
using DesafioCDC.Domain.Requests;

namespace DesafioCDC.Domain.Mapping
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
