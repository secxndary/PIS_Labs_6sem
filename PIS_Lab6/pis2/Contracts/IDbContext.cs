using PIS_Lab6.Models;
using System.Data.Entity;

namespace PIS_Lab6.Contracts
{
    public interface IDbContext
    {
        DbSet<Phone> Phone { get; set; }

        void SaveChanges();
    }
}
