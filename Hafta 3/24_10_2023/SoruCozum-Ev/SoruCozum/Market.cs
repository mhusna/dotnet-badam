using SoruCozum.Interfaces;
using SoruCozum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruCozum
{
    internal class Market
    {
        public StockManagement StockManagement { get; set; }
        public PersonelManagement PersonelManagement { get; set; }

        public Market()
        {
            StockManagement = new StockManagement();
            PersonelManagement = new PersonelManagement();
        }
    }
}
