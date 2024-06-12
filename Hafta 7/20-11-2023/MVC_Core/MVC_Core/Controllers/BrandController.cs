using Microsoft.AspNetCore.Mvc;
using MVC_Core.Data;
using MVC_Core.Models;

namespace MVC_Core.Controllers
{
    public class BrandController : Controller
    {
        private readonly ProductContext _productContext;

        public BrandController(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public IActionResult Index()
        {
            /*
             => Artık böyle kullanmamak gerekli.
            ProductContext productContext = new ProductContext();
            return View(productContext.Brands);
            */
            //_productContext.Brands
            return View(_productContext.Brands.ToList());
        }

        public IActionResult InsertBrand()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InsertBrand(Brand brand)
        {
            _productContext.Brands.Add(brand);
            _productContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
