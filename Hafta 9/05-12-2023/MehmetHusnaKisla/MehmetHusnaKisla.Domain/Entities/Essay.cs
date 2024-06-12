using MehmetHusnaKisla.Domain.Entities.Abstract;
using MehmetHusnaKisla.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Domain.Entities
{
    public class Essay :IBaseEntity
    {
        public int EssayID { get; set; }
        public string EssayName { get; set; }
        public string EssayContent { get; set; }

        [ForeignKey("Publisher")]
        public int PublisherID { get; set; }
        public AppUser Publisher { get; set; }

        public int TopicID { get; set; }
        public Topic? Topic { get; set; }

        public DateTime InsertDate { get; set; }
        public DateTime DeleteDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public RecordStatus RecordStatus { get; set; }
    }
}
