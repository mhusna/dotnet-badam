using AutoMapper;
using MehmetHusnaKisla.Application.Models.DTOs.Topic;
using MehmetHusnaKisla.Domain.Entities;
using MehmetHusnaKisla.Domain.Enums;
using MehmetHusnaKisla.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Application.Services.TopicService
{
    public class TopicService : ITopicService
    {
        private readonly ITopicRepository _topicRepository;
        private readonly IMapper _mapper;

        public TopicService(ITopicRepository topicRepository, IMapper mapper)
        {
            _topicRepository = topicRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TopicDTO>> GetAllActiveTopics()
        {
            var listOfTopics = await _topicRepository.GetAllEntitiesWithFilterAsync(x => x.RecordStatus == RecordStatus.Active);

            List<TopicDTO> topicDTOs = new List<TopicDTO>();
            _mapper.Map(listOfTopics, topicDTOs);

            return topicDTOs;
        }

        public async Task<IEnumerable<TopicDTO>> GetAllTopics()
        {
            var listOfTopics = await _topicRepository.GetAllEntitiesWithoutFilterAsync();

            List<TopicDTO> topicDTOs = new List<TopicDTO>();
            _mapper.Map(listOfTopics, topicDTOs);

            return topicDTOs;
        }

        public async Task<int> TopicCount()
        {
            var listOfTopics = await _topicRepository.GetAllEntitiesWithFilterAsync(x => x.RecordStatus == RecordStatus.Active);
            return listOfTopics.Count();
        }

        public async Task TopicInsert(TopicInsertDTO topicInsertDTO)
        {
            Topic topic = new Topic();
            _mapper.Map(topicInsertDTO, topic);

            await _topicRepository.InsertEntity(topic);
        }
    }
}
