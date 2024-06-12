using AbstractFactoryPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Concrete
{
    internal class VintageTable : Furniture
    {
        public override string Name { get; set; } = "Vintage Table";
        public override string Description { get; set; } = "For everywhere..";
        public override double Price { get; set; } = 990;

        public override string ToString()
        {
            return $"{Name} - {Description} - {Price}";
        }
    }
}
