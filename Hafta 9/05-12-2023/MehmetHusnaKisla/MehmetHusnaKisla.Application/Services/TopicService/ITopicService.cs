using MehmetHusnaKisla.Application.Models.DTOs.Topic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Application.Services.TopicService
{
    public interface ITopicService
    {
        Task<IEnumerable<TopicDTO>> GetAllActiveTopics();
        Task<IEnumerable<TopicDTO>> GetAllTopics();
        Task TopicInsert(TopicInsertDTO topicInsertDTO);

        Task<int> TopicCount();
    }
}
