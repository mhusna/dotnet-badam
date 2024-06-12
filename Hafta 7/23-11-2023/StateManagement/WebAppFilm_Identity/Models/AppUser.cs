using Microsoft.AspNetCore.Identity;

namespace WebAppFilm_Identity.Models
{
    public class AppUser : IdentityUser<int>
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
