using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleCRUDOperationMVC.Models;

namespace SimpleCRUDOperationMVC.Controllers
{
    public class PersonelController : Controller
    {
        private readonly PersonelContext _context;

        public PersonelController(PersonelContext context)
        {
            _context = context;
        }

        // GET: Personel
        public ActionResult Index()
        {
            var personels=_context.Personels.ToList();
            return View(personels);
        }

        // GET: Personel/Details/5
        public ActionResult Details(int id)
        {
            var personel = _context.Personels.FirstOrDefault(x => x.Id == id);
            return View(personel);
        }

        // GET: Personel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personel/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Personel personel)
        {
            try
            {
                var addedPersonel = _context.Personels.Add(personel);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Personel/Edit/5
        public ActionResult Edit(int id)
        {
            var personel = _context.Personels.Where(p => p.Id == id).FirstOrDefault();
            return View(personel);
        }

        // POST: Personel/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( Personel personel)
        {
            try
            {
                _context.Attach(personel);
                _context.Entry(personel).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Index");
            }
        }

        // GET: Personel/Delete/5
        public ActionResult Delete(int id)
        {
            var personel = _context.Personels.Where(p => p.Id == id).FirstOrDefault();
            return View(personel);
        }

        // POST: Personel/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Personel personel)
        {
            try
            {
                _context.Attach(personel);
                _context.Entry(personel).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
