﻿using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class Musteri : Kisi
    {
        public string? HesapNo { get; set; }
        public double Bakiye { get; set; }
        public Islem IslemTipi { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" - {HesapNo} - {Bakiye} - {IslemTipi.GetType().Name}";
        }
    }
}
