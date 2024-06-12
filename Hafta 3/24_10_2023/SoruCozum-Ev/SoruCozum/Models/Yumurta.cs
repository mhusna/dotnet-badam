using SoruCozum.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SoruCozum.Models
{
    internal class Yumurta : Product, IBreakable, ISkt
    {
        public bool IsBroken { get; set; }
        public DateTime SKT { get; set; }

        public override string ToString()
        {
            return $"{ProductID} - {ProductName} - {Price} - Kırık mı: {IsBroken} - {SKT}";
        }
    }
}
