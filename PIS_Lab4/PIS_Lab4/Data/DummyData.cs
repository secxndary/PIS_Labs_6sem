using System.Collections.Generic;
using PIS_Lab4.Models;

namespace PIS_Lab4.Data
{
    public class DummyData
    {
        public static List<PhoneBook> GetPhoneBooks()
        {
            return new List<PhoneBook>() 
            { 
                new PhoneBook() {Id = 1, Name = "Alexander", Surname = "Valdaitsevv", PhoneNumber = "+375445573501"},
                new PhoneBook() {Id = 2, Name = "Katherine", Surname = "Vrublevskayaa", PhoneNumber = "+375333827583"}
            };
        }
    }
}