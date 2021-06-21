using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using x_wingbackend.Models;
using x_wingbackend.DTO;

namespace x_wingbackend.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize() => new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Ship, ShipDto>();
            cfg.CreateMap<Player, ShipDto>();
        }).CreateMapper();
    }
}
