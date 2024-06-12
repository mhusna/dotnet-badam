namespace MVC_Core.Models
{
    public class KitapListeleVM
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public double Fiyat { get; set; }
        public string KategoriAdi { get; set; }
        public string YazarAdi { get; set; }

        // Resim için sonradan eklenmiştir.
        public string FilePath { get; set; }
    }
}
