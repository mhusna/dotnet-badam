using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_II_Tekrar
{
    public enum Konum
    {
        OnSag, OnSol, ArkaSag, ArkaSol
    }
    public class Lastik
    {
        public Konum Konum { get; set; }
    }
}
