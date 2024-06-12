using AutoMapper;
using MehmetHusnaKisla.Application.Models.DTOs;
using MehmetHusnaKisla.Application.Models.VMs;
using MehmetHusnaKisla.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Application.Mapper
{
    public class EssayMapper : Profile
    {
        public EssayMapper()
        {
            CreateMap<EssayInsertDTO, Essay>().ReverseMap();
            CreateMap<EssayUpdateDTO, Essay>().ReverseMap();

            CreateMap<EssayListVM, Essay>().ReverseMap()
                                           .ForMember(x => x.PublisherName, x => x.MapFrom(x => x.Publisher.UserName))
                                           .ForMember(x => x.TopicName, x => x.MapFrom(x => x.Topic.TopicName));

            CreateMap<EssayDetailVM, Essay>().ReverseMap()
                                             .ForMember(x => x.PublisherName, x => x.MapFrom(x => x.Publisher.UserName))
                                             .ForMember(x => x.TopicName, x => x.MapFrom(x => x.Topic.TopicName)); ;
        }
    }
}
