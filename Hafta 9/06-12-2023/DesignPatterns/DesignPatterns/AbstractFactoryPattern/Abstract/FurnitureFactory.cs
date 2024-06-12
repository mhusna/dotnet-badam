using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Abstract
{
    internal abstract class FurnitureFactory
    {
        public abstract Furniture CreateTable();
        public abstract Furniture CreateChair();

    }
}
