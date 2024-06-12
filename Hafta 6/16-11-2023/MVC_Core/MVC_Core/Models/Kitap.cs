namespace MVC_Core.Models
{
    public class Kitap
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public double Fiyat { get; set; }
        public int KategoriID { get; set; }
        public Kategori Kategori { get; set; }
        public int YazarID { get; set; }
        public Yazar Yazar { get; set; }
    }
}
