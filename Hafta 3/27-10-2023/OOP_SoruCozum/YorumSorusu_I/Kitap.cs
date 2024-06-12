using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YorumSorusu_I
{
    internal class Kitap
    {
        public int KitapID { get; set; }
        public string ISBN { get; private set; }
        public Kitap(int id, string isbn)
        {
            KitapID = id;
            ISBN = isbn;
        }

        void Deneme()
        {
            ISBN = "abc";
        }
    }
}
