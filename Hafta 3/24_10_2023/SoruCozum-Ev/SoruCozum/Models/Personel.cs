using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruCozum.Models
{
    internal abstract class Personel
    {
        public int PersonelID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
    }
}
