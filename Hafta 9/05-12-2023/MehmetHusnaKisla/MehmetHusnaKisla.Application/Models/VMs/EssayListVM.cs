using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Application.Models.VMs
{
    public class EssayListVM
    {
        public int EssayID { get; set; }
        public string EssayName { get; set; }
        public string PublisherName { get; set; }
        public string TopicName { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
