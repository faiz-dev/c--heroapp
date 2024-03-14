using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Model;

namespace WinFormsApp2
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;database=herodb;Trusted_Connection=true;TrustServerCertificate=True");
        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
