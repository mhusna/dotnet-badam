using System.ComponentModel.DataAnnotations;

namespace MVC_Core.Models
{
    public class Brand
    {
        public int BrandID { get; set; }
        [Display(Name ="Marka Adı:")]
        public string Name { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
