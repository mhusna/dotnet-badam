using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_III
{
    internal class Test : IArayuz1, IArayuz2
    {
        void IArayuz1.Islem()
        {
            throw new NotImplementedException();
        }

        void IArayuz2.Islem()
        {
            throw new NotImplementedException();
        }
    }
}
