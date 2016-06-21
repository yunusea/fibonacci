using DataLayer.FibonacciNumbers.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.FibonacciNumbers.DataContext
{
    public class FibonacciNumberDataContext : DbContext
    {
        public DbSet<Query> Query { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
