using Microsoft.AspNetCore.Mvc;
using MVC_Core.Data;
using MVC_Core.Models;

namespace MVC_Core.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ProductContext _productContext;
        public CategoryController(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public IActionResult Index()
        {
            return View(_productContext.Categories.ToList());
        }

        public IActionResult InsertCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InsertCategory(Category category)
        {
            _productContext.Categories.Add(category);
            _productContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
