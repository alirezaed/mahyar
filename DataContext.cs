using Microsoft.EntityFrameworkCore;
using ServicesReviewApp.Models;

namespace ServicesReviewApp.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {
            
        }
        public DbSet<cars> cars { get; set; }
        public DbSet<customers> customers { get; set; }
        public DbSet<Parts> parts { get; set; } 
        public DbSet<Services> services { get; set; }
        public DbSet<ServicesDetails> servicesDetails { get; set; }
        public DbSet<ServiceType> serviceTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServicesDetails>()
                .HasKey(Se => new { Se.ServiceNumber, Se.PartId });
            modelBuilder.Entity<ServicesDetails>()
                .HasOne(s => s.Services)
                .WithMany(Se => Se.servicesDetails)
                .HasForeignKey(e => e.ServiceNumber);
            modelBuilder.Entity<ServicesDetails>()
                .HasOne(s=>s.Parts)
                .WithMany(Se=>Se.servicesDetails)
                .HasForeignKey(e=>e.PartId);
        }
        
    }
}
