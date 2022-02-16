using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaRoupaAPIWeb.Models
{
    public class FilmeContext : DbContext
    {
        public DbSet<Filme> Filmes { get; set; }

        public FilmeContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-A86BJI0;Initial Catalog=FilmeSerie;User ID=sa;Password=1234");
        }
    }
}
