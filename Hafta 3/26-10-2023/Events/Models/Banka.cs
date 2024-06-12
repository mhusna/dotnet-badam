namespace Models
{
    public class Banka
    {
        public List<Personel> Personeller;
        public List<Banko> Bankolar;
        public List<Musteri> Musteriler;

        public Banka()
        {
            Personeller = new List<Personel>();
            Bankolar = new List<Banko>();
            Musteriler = new List<Musteri>();
        }

        public void IslemYap(Musteri musteri)
        {
            bool islemYapiliyor = false;
            foreach (Banko banko in Bankolar)
            {
                if (banko.Durum == true)
                {
                    Musteriler.Add(musteri);
                    banko.MusteriAl(musteri);
                    islemYapiliyor = true;
                    //break;
                }
            }

            if(!islemYapiliyor)
                Console.WriteLine("Tüm bankolar dolu");
            else
                Console.WriteLine("İşlem yapıldı..");
        }
    }
}