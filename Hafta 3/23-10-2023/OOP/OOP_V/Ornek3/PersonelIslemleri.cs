using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_V.Ornek3
{
    internal class PersonelIslemleri<T> where T : Personel
    {
        public void IseAl(T personel) { }
    }
}
