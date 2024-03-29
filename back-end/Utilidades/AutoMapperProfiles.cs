﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back_end.DTO;
using back_end.Entidades;
using NetTopologySuite.Geometries;

namespace back_end.Utilidades
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles(GeometryFactory geometryFactory)
        {
            CreateMap<Uso, UsoDTO>().ReverseMap();
            CreateMap<Suscriptor, SuscriptorDTO>().ReverseMap();
        }
    }
}
