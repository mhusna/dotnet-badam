using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class Single
    {
        private static Single instance = null;
        private Single() { }

        public static Single GetSingle()
        {
            if(instance == null)
             instance = new Single();

            return instance;
        }
    }
}
