using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Richard.Tutorial.Model;
using Richard.Tutorial.DTL;

namespace Richard.Tutorial.Middleware
{
    public static class AutoMapperSetup
    {
        
        public static void SetUpAutoMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Cities, CityDTO>().ReverseMap();
                cfg.CreateMap<Countries, CountryDTO>().ReverseMap();
                cfg.CreateMap<OrdersByUser, OrdersByUserDTO>().ReverseMap();
                cfg.CreateMap<Orders, OrdersDTO>().ReverseMap();
                cfg.CreateMap<Users, UserDTO>().ReverseMap();
            });
        }

        public static void SetUpAutoMapper(object assemble)
        {
            throw new NotImplementedException();
        }
    }
}
