using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_V_DIP.Cozum
{
    public class DbManager
    {
        private ICRUD _crud;

        public DbManager() { }

        /* CTOR INJECTION (Loosely Coupling) */
        public DbManager(ICRUD crud)
        {
            _crud = crud;
        }

        /* METHOD INJECTION */
        public void Inject(ICRUD crud)
        {
            _crud = crud;
        }

        /* PROPERTY INJECTION */
        public ICRUD InjectProp { get { return _crud; } set { _crud = value; } }

        public string Oku()
        {
            return _crud.Read();
        }
    }
}
