using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HandsOnMVCusingHelpersandModelValidation.Models;
namespace HandsOnMVCusingHelpersandModelValidation.Context
{
    public class EMSContext:DbContext
    {
        //public EMSContext() { }
        public EMSContext(DbContextOptions<EMSContext> options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=EMSDB1;User ID=sa;Password=pass@word1");
        }
        public DbSet<Employee> Employees { get; set; }

    }
}
