using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleEstacionamento.Model
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base (options)
        {

        }

        public DbSet<Entrada> Cliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}
