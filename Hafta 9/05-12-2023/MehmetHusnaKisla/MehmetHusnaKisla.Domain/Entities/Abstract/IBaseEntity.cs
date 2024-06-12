using MehmetHusnaKisla.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Domain.Entities.Abstract
{
    public interface IBaseEntity
    {
        public DateTime InsertDate { get; set; }
        public DateTime DeleteDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public RecordStatus RecordStatus { get; set; }
    }
}
