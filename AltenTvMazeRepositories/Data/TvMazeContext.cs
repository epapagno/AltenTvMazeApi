using AltenTvMazeModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltenTvMazeRepositories.Data
{
    public class TvMazeContext : DbContext
    {
        
        const string connectionString = "Host=localhost;Port=5432;Database=tvmaze;Username=postgres;Password=admin";

        public TvMazeContext() : base() { }

        public TvMazeContext(DbContextOptions<TvMazeContext> options) : base(options) { }

        public DbSet<Show> Shows { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configurar propiedades adicionales si es necesario
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}
