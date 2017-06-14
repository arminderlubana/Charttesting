using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Cureve.Models.dynamic.Models;

namespace Cureve.DAL
{
    public class ChartContext : DbContext
    {
        public ChartContext() : base("DefaultConnection")
        {
        }

        public DbSet<ProductModel> ProductModel { get; set; }
        public DbSet<Product> Product { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}