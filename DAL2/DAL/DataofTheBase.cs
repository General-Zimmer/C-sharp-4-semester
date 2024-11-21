using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data;
using BLL2.models;

namespace DAL2.DAL
{
    public class DataofTheBase : DbContext
    {
        public DataofTheBase() : base("Biler")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Bill> Biler { get; set; }
    }
}
