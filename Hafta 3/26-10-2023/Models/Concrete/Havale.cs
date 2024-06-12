using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class Havale : Islem
    {
        public override string IslemAdi { get { return "Havale"; } }

        public override int Sure { get { return 5; } }

        public override IslemTipi IslemTipi { get { return IslemTipi.Havale; } }
    }
}
