﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Marka
    {
        public int MarkaID { get; set; }
        public string MarkaAdi { get; set; }
        public ICollection<Araba>? Arabalar { get; set; }
        public ICollection<Model>? Modeller { get; set; }
    }
}
