using CeylanTurizm.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeylanTurizm.Data.Concrete.EfCore
{
    public class CeylanTurizmDbContext : DbContext
    {
        public DbSet<Expedition> Expeditions { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<TicketSales> TicketSales { get; set; }
        public DbSet<City> Cities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-GGAL04A;Database=CeylanTurizm;User=sa;Pwd=535598;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TicketSales>()
                .HasKey(a => a.TicketSalesId);
        }
    }
}
