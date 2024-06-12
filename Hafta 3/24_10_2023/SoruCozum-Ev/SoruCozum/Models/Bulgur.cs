using SoruCozum.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruCozum.Models
{
    internal class Bulgur : Product, IRuinable, ISkt, ITett
    {
        public bool IsRuined { get; set; }
        public DateTime SKT { get;  set; }
        public DateTime Tett { get; set; }

        public override string ToString()
        {
            return $"{ProductID} - {ProductName} - {Price} - Bozuk mu: {IsRuined} - {SKT} - {Tett}";
        }
    }
}
