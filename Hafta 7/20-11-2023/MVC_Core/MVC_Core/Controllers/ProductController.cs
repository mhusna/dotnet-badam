using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Core.Data;
using MVC_Core.Models;
using System.Drawing;

namespace MVC_Core.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductContext _productContext;
        public ProductController(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public IActionResult Index()
        {
            List<Product> products = _productContext.Products.Include("Category").Include("Brand").ToList();
            return View(products);
        }

        public IActionResult InsertProduct()
        {
            ProductInsertVM model = new ProductInsertVM();
            model.Brands = new SelectList(_productContext.Brands, "BrandID", "Name");
            model.Categories = new SelectList(_productContext.Categories, "CategoryID", "Name");

            return View(model);
        }

        [HttpPost]
        public IActionResult InsertProduct(Product product)
        {
            string guid = Guid.NewGuid().ToString() + "_" + product.Image.FileName;

            string strFilePath = "wwwroot/ProductImages/" + guid;
            FileStream fileStream = new FileStream(strFilePath, FileMode.Create);
            product.Image.CopyTo(fileStream);
            fileStream.Close();

            product.ImagePath = guid;
            _productContext.Products.Add(product);
            _productContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int id)
        {
            Product product = _productContext.Products.FirstOrDefault(x => x.ProductID == id);

            if(product != null)
            {
                _productContext.Remove(product);
                _productContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult UpdateProduct(int id)
        {
            Product product = _productContext.Products.FirstOrDefault(x => x.ProductID == id);

            ProductInsertVM model = new ProductInsertVM()
            {
                Product = product,
                Brands = new SelectList(_productContext.Brands, "BrandID", "Name"),
                Categories = new SelectList(_productContext.Categories, "CategoryID", "Name")
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            Product productToUpdate = _productContext.Products.Where(x => x.ProductID == product.ProductID).FirstOrDefault();
            _productContext.Entry(productToUpdate).State = EntityState.Detached;

            string imagePath = productToUpdate.ImagePath;

            if(product.Image == null)
                product.ImagePath = imagePath;
            else
            {
                string guid = Guid.NewGuid().ToString() + "_" + product.Image.FileName;

                string strFilePath = "wwwroot/ProductImages/" + guid;
                FileStream fileStream = new FileStream(strFilePath, FileMode.Create);
                product.Image.CopyTo(fileStream);
                fileStream.Close();

                product.ImagePath = guid;
            }

            _productContext.Entry(product).State = EntityState.Modified;
            _productContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
