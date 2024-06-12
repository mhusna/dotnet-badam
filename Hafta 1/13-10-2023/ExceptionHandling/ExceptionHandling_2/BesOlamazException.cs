using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_2
{
    internal class BesOlamazException : Exception
    {
        public override string Message => "Beş olamaz.";
    }
}
