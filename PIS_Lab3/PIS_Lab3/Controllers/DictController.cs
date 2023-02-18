using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Newtonsoft.Json;
using PIS_Lab3.Models;

namespace PIS_Lab3.Controllers
{
    public class DictController : Controller
    {
        // Method to get first free ID in JSON list, 
        // e.g. if we deleted elements with id=4 and id=5,
        // this method will return me 4 as first free id.
        // If we have consecutive ids (1,2,3,...,10),
        // this method will return 11.
        private int GetFirstFreeId()
        {
            var ids = GetPhoneBooks().Select(x => x.Id).ToList();
            var firstFreeId = 0;
            for (int i = 1; i <= ids.Max(); i++)
            {
                firstFreeId = i;
                if (!ids.Contains(firstFreeId))
                    return firstFreeId;
            }
            return firstFreeId + 1;
        }


        // Get books from JSON
        private List<PhoneBook> GetPhoneBooks()
        {
            string json = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/phoneBooks.json"));
            List<PhoneBook> books = JsonConvert.DeserializeObject<List<PhoneBook>>(json);
            return books;
        }


        // GET: Index
        public ActionResult Index()
        {
            var books = GetPhoneBooks().OrderBy(x => x.Surname).ToList();
            return View(books);
        }


        // GET: Create
        public ActionResult Create()
        {
            return View();
        }


        // POST: Create
        [HttpPost]
        public ActionResult Create(PhoneBook phoneBook)
        {
            var phoneBooksIds = GetPhoneBooks().Select(x => x.Id).ToList();
            //var lastId = phoneBooksIds.Max(x => x);
            var newPhoneBook = phoneBook;
            newPhoneBook.Id = GetFirstFreeId();
            var newBooksList = GetPhoneBooks();
            newBooksList.Add(newPhoneBook);
            var convertedJson = JsonConvert.SerializeObject(newBooksList, Formatting.Indented);
            System.IO.File.WriteAllText(Server.MapPath("~/App_Data/phoneBooks.json"), convertedJson);
            return Redirect("/Dict/Index");
        }











        // GET: Dict/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Dict/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dict/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dict/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }





        //// Sort the table
        //public ActionResult SortByColumn(string column)
        //{
        //    var books = GetPhoneBooks();
        //    switch (column)
        //    {
        //        case "Name":
        //            books = books.OrderBy(x => x.Name).ToList();
        //            break;
        //        case "Surname":
        //            books = books.OrderBy(x => x.Surname).ToList();
        //            break;
        //        default:
        //            break;
        //    }

        //    return PartialView("_PhoneBookTable", books);
        //}
    }
}
