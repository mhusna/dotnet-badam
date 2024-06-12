using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Abstract
{
    public abstract class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public override string ToString()
        {
            return $"Ad: {Ad} {Soyad} ";
        }
    }
}
