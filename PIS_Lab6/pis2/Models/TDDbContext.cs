using PIS_Lab6.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PIS_Lab6.Models
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