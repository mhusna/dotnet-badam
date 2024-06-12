using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Abstract
{
    internal interface IMediator
    {
        void Register(User user);
        void SendMessage(string message, User user);
    }
}
