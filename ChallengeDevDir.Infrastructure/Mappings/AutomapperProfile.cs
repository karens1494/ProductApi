using AutoMapper;
using ChallengeDevDir.Core.DTOs;
using ChallengeDevDir.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeDevDir.Infrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Producto, ProductDto>();
            CreateMap<ProductDto, Producto>();
        }
    }
}
