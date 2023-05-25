using PIS_Lab6.Contracts;
using System.Collections.Generic;


namespace PIS_Lab6.Models
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