using pis2.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace pis2.Models
{
    public class TD : ITD
    {
        public void Add(string phoneNumber, string ownerName)
        {
            JsonHelper.AppendToEnd(phoneNumber, ownerName);
        }

        public void Delete(int id)
        {
            JsonHelper.Delete(id);
        }

        public Phone Get(int id)
        {
            return null;
        }

        public IEnumerable<Phone> GetAll()
        {
            return JsonHelper.LoadFromJson();
        }

        public void Update(Phone phone)
        {
            JsonHelper.Update(phone);
        }
    }
}