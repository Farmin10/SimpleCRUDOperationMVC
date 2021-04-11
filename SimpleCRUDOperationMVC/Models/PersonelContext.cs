using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCRUDOperationMVC.Models
{
    public class PersonelContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Desktop-Psjtqan;database=PersonelsContext;integrated security=true");
        }
        public DbSet<Personel> Personels { get; set; }
    }
}
