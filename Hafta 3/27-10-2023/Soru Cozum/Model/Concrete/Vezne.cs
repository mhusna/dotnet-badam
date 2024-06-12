using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Concrete
{
    public class Vezne
    {
        public string No { get; set; }
        public VezneDurum Durum { get; set; }
        public Musteri Musteri { get; set; }
        public Personel Personel { get; set; }

        public override string ToString()
        {
            return $"Vezne no: {No} - V.Durum: {Durum} - {Personel} - {Musteri}";
        }
    }
}
