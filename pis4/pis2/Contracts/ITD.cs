using pis2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pis2.Contracts
{
    public interface ITD
    {
        IEnumerable<Phone> GetAll();
        Phone Get(int id);
        void Add(string phoneNumber, string ownerName);
        void Delete(int id);
        void Update(Phone phone);
    }
}
