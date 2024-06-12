using SoruCozum.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SoruCozum.Models
{
    internal class KagitHavlu : Product, IRuinable
    {
        public bool IsRuined { get; set; }

        public override string ToString()
        {
            return $"{ProductID} - {ProductName} - {Price} - Bozuk mu: {IsRuined}";
        }
    }
}
