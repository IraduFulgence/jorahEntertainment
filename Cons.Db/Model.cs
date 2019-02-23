using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Cons.Db
{
    public class MovieContext : DbContext
    {
        public DbSet<Movietbl> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.ConsoleApp.NewDb;Trusted_Connection=True;");
        }
    }

    public class Movietbl
    {
        [Key]
        public int MovieId { get; set; }
        public string title { get; set; }
        public string year { get; set; }
        public string category { get; set; }
        public int budget { get; set; }

    }
}
