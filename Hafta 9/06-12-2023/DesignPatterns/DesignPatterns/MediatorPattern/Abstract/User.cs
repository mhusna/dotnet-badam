using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Abstract
{
    internal abstract class User
    {
        protected string Name { get; set; }
        public IMediator Mediator { get; set; }
        public User(string name)
        {
            Name = name;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
