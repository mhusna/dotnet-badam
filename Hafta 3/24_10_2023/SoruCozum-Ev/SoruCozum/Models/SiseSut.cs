using SoruCozum.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SoruCozum.Models
{
    internal class SiseSut : Product, IBreakable, IRuinable, ISkt
    {
        public bool IsRuined { get; set; }
        public bool IsBroken { get; set; }
        public DateTime SKT { get; set; }

        public override string ToString()
        {
            return $"{ProductID} - {ProductName} - {Price} - Bozuk mu: {IsRuined} - Kırık mı: {IsBroken} - {SKT}";
        }
    }
}
