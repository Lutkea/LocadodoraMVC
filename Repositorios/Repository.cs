using Microsoft.EntityFrameworkCore;
using Models;

namespace Repositories
{
    public class Context : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Locacao> Locacoes { get; set; }

        public DbSet<FilmeLocacao> FilmeLocacao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options){
            //=> options.UseMySql("Server=localhost;User Id=root;Database=bancomvc");
            options.UseMySql("Server=dbamanda.cswxngu9zfak.us-east-1.rds.amazonaws.com;User Id=admin;Password=admin123;Database=innodb");
        }
    }
}