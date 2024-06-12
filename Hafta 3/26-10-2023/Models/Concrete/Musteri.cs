using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class Musteri : IIslemTipi
    {
        public int MusteriID { get; set; }
        public string Ad { get; set; }
        public IslemTipi IslemTipi { get; set; }

        public void IslemYap(Banka banka)
        {
            banka.MusteriAl(this);
        }
    }
}
