using API_I.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_I.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly ModelContext _context;

        public FilmController(ModelContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> TumFilmler()
        {
            return Ok(await _context.Filmlers.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> FilmEkle(Filmler filmler)
        {
            await _context.Filmlers.AddAsync(filmler);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
