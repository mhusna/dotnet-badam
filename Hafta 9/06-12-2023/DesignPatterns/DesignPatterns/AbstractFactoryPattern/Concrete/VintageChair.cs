using AbstractFactoryPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Concrete
{
    internal class VintageChair : Furniture
    {
        public override string Name { get; set; } = "Vintage Chair";
        public override string Description { get; set; } = "For your comforts..";
        public override double Price { get; set; } = 100;

        public override string ToString()
        {
            return $"{Name} - {Description} - {Price}";
        }
    }
}
