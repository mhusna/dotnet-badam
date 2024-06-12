using AutoMapper;
using Haber.Application.Models.DTOs;
using Haber.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.Application.AutoMapper
{
    public class HaberMapper : Profile
    {
        public HaberMapper()
        {
            CreateMap<Kategori, KategoriDTO>().ReverseMap();
            CreateMap<Haber.Domain.Entities.Haber, HaberEkleDTO>().ReverseMap();
        }
    }
}
