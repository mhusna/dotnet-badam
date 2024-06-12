namespace Soru18
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
        public KoltukTipi KoltukTipi { get; set; }
    }
}