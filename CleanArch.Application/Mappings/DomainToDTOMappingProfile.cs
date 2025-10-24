using AutoMapper;
using CleanArch.Domain.Entities;

namespace CleanArch.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Category, DTOs.CategoryDTO>().ReverseMap();
            CreateMap<Product, DTOs.ProductDTO>().ReverseMap();
        }
    }
}
