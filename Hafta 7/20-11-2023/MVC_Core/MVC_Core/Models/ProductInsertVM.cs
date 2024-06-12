using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVC_Core.Models
{
    public class ProductInsertVM
    {
        public Product Product { get; set; }
        public SelectList Brands { get; set; }
        public SelectList Categories { get; set; }
    }
}
