using MehmetHusnaKisla.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Application.Models.DTOs
{
    public class EssayUpdateDTO
    {
        public int EssayID { get; set; }
        public string EssayName { get; set; }
        public string EssayContent { get; set; }
        public int PublisherID { get; set; }
        public int TopicID { get; set; }
    }
}
