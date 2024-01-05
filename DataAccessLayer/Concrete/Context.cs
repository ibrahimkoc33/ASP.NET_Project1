
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql("Host=localhost; Database=deneme2; Username=postgres; Password=6843");
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Rewiew> Rewiews { get; set; }
        public DbSet<Celebrities> Celebrities { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
