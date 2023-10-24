using Microsoft.EntityFrameworkCore;
using SiteFinal.Models;

namespace SiteFinal.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Pessoa> Pessoa { get; set; }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<CadastroProduto> CadastroProduto { get; set; }

        public DbSet<Marca> Marca { get; set; }
    }
}