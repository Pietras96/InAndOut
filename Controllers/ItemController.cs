using InAndOut.Data;
using InAndOut.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Item> objList = _db.Items;
            return View(objList);
        }

        //get create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //post create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Item obj)
        {
            _db.Items.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Item obj)
        {
            try
            {
                _db.Items.Update(obj);
                _db.SaveChanges();
                TempData["Message"] = "";
            }
            catch (Exception e)
            {
                TempData["Message"] = "Wystapil blad podczas proby aktualizacji obiektu!: " + e.Message;
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Item obj = _db.Items.Where(x => x.Id == id).FirstOrDefault();
            return View("Edit", obj);
        }
      
        public IActionResult Delete(int id)
        {
            Item obj = _db.Items.Where(x => x.Id == id).FirstOrDefault();
            try
            {
                _db.Items.Remove(obj);
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                TempData["Message"] = "Wystapil blad podczas proby usuniecia obiektu!: " + e.Message;
            }
            return RedirectToAction("Index");
        }

    }
}
