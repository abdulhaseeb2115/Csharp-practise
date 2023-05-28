using Assign5.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assign5.Controllers
{
    public class ChildController : Controller
    {

        private Assign5DBContext db = new Assign5DBContext();


        public ActionResult add(int x = 91, int y = 91)
        {
            ViewData["sum"] = x + y;
            return View();
        }

        public string add1(int x, int y)
        {
            return (x + y).ToString();
        }







        // GET: Child
        public ActionResult Index()
        {
            return View(db.Child.ToList());
        }

        // GET: Child/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Child/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Child/Create
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

        // GET: Child/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Child/Edit/5
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

        // GET: Child/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Child/Delete/5
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
