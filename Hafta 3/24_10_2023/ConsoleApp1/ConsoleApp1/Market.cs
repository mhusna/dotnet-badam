using OOP_I.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_I
{
    internal class Market
    {
        public Stok Stoklar { get; set; }

        public Market()
        {
            Stoklar= new Stok();
        }
    }
}
