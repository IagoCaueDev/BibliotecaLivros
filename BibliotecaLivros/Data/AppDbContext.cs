using BibliotecaLivros.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaLivros.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) 
        {

        }

        public DbSet<AutorModel> Autores { get; set; }
        public DbSet<LivroModel> Livro { get; set; }    
    }
}
