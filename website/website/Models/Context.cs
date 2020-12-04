using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace website.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=BUKET-PEHLIVAN; database=personneldb; integrated security=true; ");
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Personnel> Personnels { get; set; }


    }
}
