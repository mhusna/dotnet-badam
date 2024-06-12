using AbstractFactoryPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Concrete
{
    internal class ModernFurnitureFactory : FurnitureFactory
    {
        public override Furniture CreateChair()
        {
            return new ModernChair();
        }

        public override Furniture CreateTable()
        {
            return new ModernTable();
        }
    }
}
