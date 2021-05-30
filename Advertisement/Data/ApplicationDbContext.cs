using Advertisement.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Text;

namespace Advertisement.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Advertisements> Advertisements { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Pictures> Pictures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) // konwertowanie enumów by wyświetlało nazwe
        {
            var converter = new ValueConverter<AdType, string>(
                v => v.ToString(),
                v => (AdType)Enum.Parse(typeof(AdType), v));
            modelBuilder
                .Entity<Advertisements>()
                .Property(p => p.AdTypes)
                .HasConversion(converter); // .HasConversion<string>()
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pictures>().HasOne<Advertisements>(x => x.Advertisements)
                .WithMany(x => x.PicturesCol).HasForeignKey(x => x.AdvertisementId);
            modelBuilder.Entity<Advertisements>().HasOne<ApplicationUser>(x => x.ApplicationUser)
                .WithMany(x => x.Advertisements).HasForeignKey(x => x.UserId);
        }
    }
}
