using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testBits.Models;

namespace testBits.Controllers
{
    public class HomeController : Controller
    {
        CSVContext db;
        public HomeController(CSVContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.CSVs.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CSV csvInfo)
        {
            db.CSVs.Add(csvInfo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            CSV temp = db.CSVs.Find(id);
            if (temp == null)
            {
                return RedirectToAction("Index");
            }
            db.CSVs.Remove(temp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                CSV editedUser = db.CSVs.FirstOrDefault(p => p.Id == id);
                ViewBag.username = editedUser.Name;
                ViewBag.dateDay = editedUser.DateDay;
                ViewBag.dateMonth = editedUser.DateMonth;
                ViewBag.dateyear = editedUser.DateYear;
                ViewBag.married = editedUser.Married;
                ViewBag.phone = editedUser.Phone;
                ViewBag.salary = editedUser.Salary;
                if (editedUser != null)
                    return View(editedUser);
            }
            return View("Index");
        }
        [HttpPost]
        public ActionResult Edit(CSV tempInfo)
        {
            db.CSVs.Update(tempInfo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
