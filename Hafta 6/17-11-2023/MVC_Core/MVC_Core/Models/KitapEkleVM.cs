using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVC_Core.Models
{
    public class KitapEkleVM
    {
        public Kitap Kitap { get; set; }
        public SelectList Kategoriler { get; set; }
        public SelectList Yazarlar { get; set; }
    }
}
