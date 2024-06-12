using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_IV_ISP.Yontem_II
{
    public interface IKaleci : IFutbolcu
    {
        void Kurtar();
        void ElleOyna();
    }
}
