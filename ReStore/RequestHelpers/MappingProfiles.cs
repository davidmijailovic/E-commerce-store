using AutoMapper;
using ReStore.DTOs;
using ReStoreAPI.Entities;

namespace ReStore.RequestHelpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() 
        {
            CreateMap<CreateProductDTO, Product>();
            CreateMap<UpdateProductDTO, Product>();
        }
    }
}
