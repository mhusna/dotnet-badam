using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru18
{
    public class Bus
    {
        public readonly int koltukSayisi;
        public Bus(int seatCount)
        {
            Seats = new List<Seat>();
            koltukSayisi = seatCount;
            for (int i = 0; i < koltukSayisi; i++)
            {
                int seatNumber = i + 1;

                Seat seat = new Seat(seatNumber);
                Seats.Add(seat);
            }
        }

        public Person Driver { get; set; }
        public List<Seat> Seats { get; set; }
    }
}
