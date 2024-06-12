using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Core.Data;
using MVC_Core.Models;

namespace MVC_Core.Controllers
{
    public class UrunController : Controller
    {
        private readonly ProductContext _context;

        public UrunController(ProductContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var productContext = _context.Products.Include(p => p.Brand).Include(p => p.Category);
            return View(await productContext.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        public IActionResult Create()
        {
            ProductInsertVM model = new ProductInsertVM();

            model.Brands = new SelectList(_context.Brands, "BrandID", "Name");
            model.Categories = new SelectList(_context.Categories, "CategoryID", "Name");
            
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {
                product.ImagePath = DosyaKaydet(product.Image);
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ProductInsertVM model = new ProductInsertVM()
            {
                Brands = new SelectList(_context.Brands, "BrandID", "BrandID", product.BrandID),
                Categories = new SelectList(_context.Categories, "CategoryID", "CategoryID", product.CategoryID)
            };

            return View(model);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            ProductInsertVM model = new ProductInsertVM()
            {
                Product = product,
                Brands = new SelectList(_context.Brands, "BrandID", "Name", product.BrandID),
                Categories = new SelectList(_context.Categories, "CategoryID", "Name", product.CategoryID)
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Product product)
        {
            if (id != product.ProductID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    if (product.Image != null)
                    {
                        if (product.ImagePath != product.Image.FileName)
                        {
                            // Kullanıcı dosyayı değiştirdi.
                            System.IO.File.Delete("wwwroot/ProductImages/" + product.ImagePath);
                            product.ImagePath = DosyaKaydet(product.Image);
                        }
                    }
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            ProductInsertVM model = new ProductInsertVM()
            {
                Brands = new SelectList(_context.Brands, "BrandID", "Name", product.BrandID),
                Categories = new SelectList(_context.Categories, "CategoryID", "Name", product.CategoryID)
            };

            return View(model);
        }

        // GET: Urun/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Urun/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Products == null)
            {
                return Problem("Entity set 'ProductContext.Products'  is null.");
            }
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
          return (_context.Products?.Any(e => e.ProductID == id)).GetValueOrDefault();
        }

        private string DosyaKaydet(IFormFile file)
        {
            string guid = Guid.NewGuid().ToString() + "_" + file.FileName;

            string strFilePath = "wwwroot/ProductImages/" + guid;
            FileStream fileStream = new FileStream(strFilePath, FileMode.Create);
            file.CopyTo(fileStream);
            fileStream.Close();

            return guid;
        }
    }
}
