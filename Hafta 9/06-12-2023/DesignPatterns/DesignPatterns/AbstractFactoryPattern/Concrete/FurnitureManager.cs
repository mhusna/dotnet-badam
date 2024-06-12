using AbstractFactoryPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Concrete
{
    internal class FurnitureManager
    {
        private readonly FurnitureFactory _factory;

        public FurnitureManager(FurnitureFactory factory)
        {
            _factory = factory;
        }

        public Furniture CreateTable()
        {
            return _factory.CreateTable();
        }

        public Furniture CreateChair()
        {
            return _factory.CreateChair();
        }
    }
}
