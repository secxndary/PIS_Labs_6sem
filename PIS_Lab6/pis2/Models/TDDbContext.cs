using pis2.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace pis2.Models
{
    public class TDDbContext : DbContext, IDbContext
    {

        public DbSet<Phone> Phone { get; set; }

        public TDDbContext() : base("name=MyConnectionString")
        {
        }

        void IDbContext.SaveChanges()
        {
            SaveChanges();
        }
    }
}