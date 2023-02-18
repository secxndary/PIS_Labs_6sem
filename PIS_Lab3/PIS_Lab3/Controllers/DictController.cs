using System.Collections.Generic;
using System.Web.Mvc;
using Newtonsoft.Json;
using PIS_Lab3.Models;

namespace PIS_Lab3.Controllers
{
    public class DictController : Controller
    {
        // GET: Dict
        public ActionResult Index()
        {
            string json = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/phoneBooks.json"));
            List<PhoneBook> books = JsonConvert.DeserializeObject<List<PhoneBook>>(json);
            return View(books);
        }

 
        // GET: Dict/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dict/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
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
    }
}
