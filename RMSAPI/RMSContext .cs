using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using RMSAPI.Models;
using System.Reflection.Metadata;

namespace RMSAPI
{
    public class RMSContext : DbContext
    {
        public DbSet<Categoria> Categoria
        {
            get; set;
        }
        public DbSet<Produto> Produto
        {
            get; set;
        }
        public DbSet<Usuario> Usuario
        {
            get; set;
        }
        public string DbPath { get; }

        public RMSContext()
        {
            var folder = System.IO.Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(folder, "rms.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }
    }
}
