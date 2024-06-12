using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebAppFilm_Identity.Data;
using WebAppFilm_Identity.Models;

namespace WebAppFilm_Identity.Controllers
{
    public class FilmController : Controller
    {
        private readonly ModelContext _modelContext;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public FilmController(ModelContext modelContext, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _modelContext = modelContext;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        private async Task<IActionResult> AddRoles()
        {
            await _roleManager.CreateAsync(new AppRole() {Name="Admin" });
            await _roleManager.CreateAsync(new AppRole() {Name="Uye" });
            return Content("İşlem başarılı..");
        }
    }
}
