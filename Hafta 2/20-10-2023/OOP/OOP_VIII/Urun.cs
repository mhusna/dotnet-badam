using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_VIII
{
    internal class Urun<T>
    {
        public void UrunEkle(T entity) { }
        public List<T> Listele() { return new List<T>(); }
    }
}
