using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru15
{
    public class Seat
    {
        public Seat(int number)
        {
            Number = number;
        }

        public int Number { get; }

        private Person _passenger;
        public Person Passenger 
        {
            get
            {
                return _passenger;
            }
            set
            {
                if (Passenger != null)
                    Console.WriteLine("Koltuk zaten dolu !");
                else
                    _passenger = value;
            }
        }
        public KoltukDurum Durum { get; set; }
    }
}
