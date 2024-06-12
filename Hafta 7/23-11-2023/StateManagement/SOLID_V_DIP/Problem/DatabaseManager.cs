using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_V_DIP.Problem
{
    public class DatabaseManager
    {
        public DatabaseManager()
        {
            /* Tightly Coupling (Sıkı bağlı..) */

            //Oracle oracle = new Oracle();
            SQL sql = new SQL();
        }
    }
}
