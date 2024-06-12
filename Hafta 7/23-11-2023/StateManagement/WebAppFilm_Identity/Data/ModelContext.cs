using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppFilm_Identity.Models;

namespace WebAppFilm_Identity.Data
{
    public class ModelContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public ModelContext(DbContextOptions<ModelContext> options) : base(options) { }

        public DbSet<Film> Filmler { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Film>().ToTable("FILMLER");
        }
    }
}
