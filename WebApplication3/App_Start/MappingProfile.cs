using AutoMapper;
using WebApplication3.Dtos;
using WebApplication3.Models;


namespace WebApplication3.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<CityDto, City>();
            Mapper.CreateMap<City, CityDto>();
        }
    }
}