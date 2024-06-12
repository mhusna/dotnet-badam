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
    public class Topic : IBaseEntity
    {
        public int TopicID { get; set; }
        public string TopicName { get; set; }

        [ForeignKey("User")]
        public int InserterID { get; set; }
        public AppUser User { get; set; }

        public ICollection<Essay> Essays { get; set; }

        public DateTime InsertDate { get; set; }
        public DateTime DeleteDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public RecordStatus RecordStatus { get; set; }
    }
}
