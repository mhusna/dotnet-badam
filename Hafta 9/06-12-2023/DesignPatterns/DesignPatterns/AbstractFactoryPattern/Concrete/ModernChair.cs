using AbstractFactoryPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Concrete
{
    internal class ModernChair : Furniture
    {
        public override string Name { get; set; } = "Modern Chair";
        public override string Description { get; set; } = "For modern environments..";
        public override double Price { get; set; } = 1200;

        public override string ToString()
        {
            return $"{Name} - {Description} - {Price}";
        }
    }
}
