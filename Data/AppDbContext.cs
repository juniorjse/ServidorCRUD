using Microsoft.EntityFrameworkCore;
using MeuServidorCRUD.Models;

namespace MeuServidorCRUD.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
