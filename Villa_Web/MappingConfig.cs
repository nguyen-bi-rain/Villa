﻿using AutoMapper;
using Villa_Web.Models;

namespace Villa_Web
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        {
           CreateMap<VillaDTO,VillaCreateDTO>().ReverseMap();
           CreateMap<VillaDTO,VillaUpdateDTO>().ReverseMap();

           

            CreateMap<VillaNumberDTO, VillaNumberUpdateDTO>().ReverseMap();
            CreateMap<VillaNumberDTO, VillaNumberCreateDTO>().ReverseMap();
            

        }
    }
}
