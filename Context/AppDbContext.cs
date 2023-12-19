using DesafioEvertMind.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioEvertMind.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Produtos> Produto { get; set; }
    }
}
