using AutoMapper;
using MehmetHusnaKisla.Application.Models.DTOs.Topic;
using MehmetHusnaKisla.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Application.Mapper
{
    public class TopicMapper : Profile
    {
        public TopicMapper()
        {
            CreateMap<TopicDTO, Topic>().ReverseMap();

            CreateMap<TopicInsertDTO, Topic>().ReverseMap();
        }
    }
}
