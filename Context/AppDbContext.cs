using crud_razor_web_app.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_razor_web_app.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Product> Products { get; set; }
    }
}
