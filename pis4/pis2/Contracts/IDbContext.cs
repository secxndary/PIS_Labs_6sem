using pis2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pis2.Contracts
{
    public interface IDbContext
    {
        DbSet<Phone> Phone {get;set;}
        void SaveChanges();
    }
}
