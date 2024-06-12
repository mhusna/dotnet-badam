using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Xml : Dosya
    {
        public override string ToString()
        {
            return "XML";
        }
    }
}
