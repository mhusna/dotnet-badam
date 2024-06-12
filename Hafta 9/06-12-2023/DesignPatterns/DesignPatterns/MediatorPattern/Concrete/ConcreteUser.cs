using MediatorPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Concrete
{
    internal class ConcreteUser : User
    {
        public ConcreteUser(string name) : base(name)
        {
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"{Name}: {message}");
        }

        public override void Send(string message)
        {
            Mediator.SendMessage(message, this);
            Console.WriteLine($"{Name}: {message}");
        }
    }
}
