using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class ParaYatirma : Islem
    {
        public override string IslemAdi { get { return "Para Yatirma"; } }

        public override int Sure { get { return 2; } }

        public override IslemTipi IslemTipi { get { return IslemTipi.ParaYatirma; } }
    }
}
