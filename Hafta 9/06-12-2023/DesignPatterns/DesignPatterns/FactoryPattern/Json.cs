using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Json : Dosya
    {
        public override string ToString()
        {
            return "JSON";
        }
    }
}
