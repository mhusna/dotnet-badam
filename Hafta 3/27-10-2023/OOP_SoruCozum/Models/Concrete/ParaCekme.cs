using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class ParaCekme : Islem
    {
        public override string ToString()
        {
            return "Para çekme islemi yapildi...";
        }
    }
}
