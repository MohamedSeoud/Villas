﻿using Application1.DTO_s;
using Application1.Models;
using AutoMapper;

namespace Application1.AutoMapper
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig() 
        {
            CreateMap<VillaCreateDTO, Villa>().ReverseMap();
            CreateMap<VillaUpdateDTO, Villa>().ReverseMap();
            CreateMap<VillaDTO, Villa>().ReverseMap();
            CreateMap<VillaNumberCreateDTO, VillaNumber>().ReverseMap();
            CreateMap<VillaNumberUpdateDTO, VillaNumber>().ReverseMap();
            CreateMap<VillaNumberDTO, VillaNumber>().ReverseMap();
            CreateMap<RegisterationModelDTO, ApplicationUsers>().ReverseMap();

        }
    }
}
