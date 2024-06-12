using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_II.Models;

namespace WebAPI_II.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly ModelContext _context = new ModelContext();

        [HttpGet]
        public IActionResult TumUrunler()
        {
            return Ok(_context.Products.ToList());
        }

        [HttpGet("Bul")]
        public IActionResult UrunBul(int id)
        {
            return Ok(_context.Products.FirstOrDefault(x => x.ProductId == id));
        }

        [HttpPost]
        public IActionResult UrunEkle([FromBody]Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public IActionResult UrunGuncelle(Product product)
        {
            _context.Update(product);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IActionResult UrunSil(int id)
        {
            Product product = _context.Products.Where(x => x.ProductId == id).FirstOrDefault();
            _context.Products.Remove(product);
            _context.SaveChanges();

            return Ok();
        }
    }
}
