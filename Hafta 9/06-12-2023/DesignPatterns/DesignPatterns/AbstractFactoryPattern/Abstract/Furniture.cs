using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Abstract
{
    internal abstract class Furniture
    {
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract double Price { get; set; }
    }
}
