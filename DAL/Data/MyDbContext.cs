using DAL.Configuratoins;
using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class MyDbContext : DbContext
    {
  

        public DbSet<Dormitory> dormitories { get; set; }
        public DbSet<Furniture> furnitures { get; set;}
        public DbSet<Inmate> inmates { get; set; }
        public DbSet<Room> rooms { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new DormintoryConfiguration());
            modelBuilder.ApplyConfiguration(new RoomConfiguration());
            modelBuilder.ApplyConfiguration(new FurnitureConfiguration());
            modelBuilder.ApplyConfiguration(new InmateConfiguration());


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=DormintoryManage;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=True;");
            }
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }
    }
}
