﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.SessionState;

namespace pis2.Models
{
    public static class JsonHelper
    {
        public static string path = @"C:\Users\valda\source\repos\semester#6\ПИС\pis4\pis2\data.json";

        public static IEnumerable<Phone> LoadFromJson() 
        {
            using (StreamReader r = File.OpenText(path))
            {
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<IEnumerable<Phone>>(json);
                return items;
            }
        }

        public static void SaveToJson(IEnumerable<Phone> phones)
        { 
            string json = JsonConvert.SerializeObject(phones, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public static void AppendToEnd(string number, string name) 
        {
            if (string.IsNullOrEmpty(number) || string.IsNullOrEmpty(name))
                return;

            var phones = LoadFromJson().ToList();
            var id = 0;

            if (phones.FirstOrDefault() != null)
                id = phones.Last().Id+1;

            phones.Add(new Phone(id, number, name));
            SaveToJson(phones);
        }

        public static void Delete(int id)
        {
            var phones = LoadFromJson().ToList();

            var item = phones.FirstOrDefault(p => p.Id == id);
            if (item == null)
                return;

            phones.Remove(item);
            SaveToJson(phones);
        }

        public static void Update(Phone phone)
        {
            if (phone == null)
                return;

            var phones = LoadFromJson().ToList();

            var item = phones.FirstOrDefault(p => p.Id == phone.Id);
            if (item == null)
                return;

            item.PhoneNumber = phone.PhoneNumber;
            item.OwnerName = phone.OwnerName;

            SaveToJson(phones);
        }
    }
}
