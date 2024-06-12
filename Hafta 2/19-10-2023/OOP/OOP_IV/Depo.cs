using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_IV
{
    internal class Depo : IEnumerable
    {
        //ArrayList _urunler = new ArrayList();
        string[] _urunler = { "Kalem", "Silgi", "Defter" };

        public IEnumerator GetEnumerator()
        {
            return _urunler.GetEnumerator();
        }
    }
}
