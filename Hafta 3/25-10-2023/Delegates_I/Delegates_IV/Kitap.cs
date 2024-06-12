﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_IV
{
    internal class Kitap
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public double Fiyat { get; set; }
        public string Kategori { get; set; }

        public override string ToString()
        {
            return $"{KitapID} {KitapAdi} {Fiyat} {Kategori}";
        }
    }
}
