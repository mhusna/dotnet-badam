using Haber.Domain.Entities.Abstract;
using Haber.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.Domain.Entities
{
    public class Yorum : IBaseEntity
    {
        public int YorumID { get; set; }
        public string YorumIcerik { get; set; }

        public int HaberID { get; set; }
        public Haber Haber { get; set; }

        public int UserID { get; set; }
        public AppUser User { get; set; }

        public DateTime EklemeTarihi { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public DateTime SilmeTarihi { get; set; }
        public KayitDurumu KayitDurumu { get; set; }
    }
}
