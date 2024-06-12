using AbstractFactoryPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Concrete
{
    internal class VintageFurnitureFactory : FurnitureFactory
    {
        public override Furniture CreateChair()
        {
            return new VintageChair();
        }

        public override Furniture CreateTable()
        {
            return new VintageTable();
        }
    }
}
