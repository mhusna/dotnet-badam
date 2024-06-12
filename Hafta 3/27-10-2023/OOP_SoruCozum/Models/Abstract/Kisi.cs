﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Abstract
{
    public abstract class Kisi
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public override string ToString()
        {
            return $"{ID} {Ad} {Soyad}";
        }
    }
}
