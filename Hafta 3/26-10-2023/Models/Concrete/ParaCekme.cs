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
        public override string IslemAdi { get { return "Para Çekme"; } }

        public override int Sure { get { return 7; } }

        public override IslemTipi IslemTipi { get { return IslemTipi.ParaCekme; } }
    }
}
