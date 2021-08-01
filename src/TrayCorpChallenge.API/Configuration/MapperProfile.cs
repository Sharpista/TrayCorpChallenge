using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrayCorpChallenge.API.DTO;
using TrayCorpChallenge.Domain.Enitites;

namespace TrayCorpChallenge.API.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
