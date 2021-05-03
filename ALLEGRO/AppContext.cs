using ALLEGRO.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALLEGRO
{
    public class AppContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server=BluE\\SQLEXPRESS; Database=Allegro; Trusted_Connection=True")
                .UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
