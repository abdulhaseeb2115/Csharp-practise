using AspPractise.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspPractise.Controllers
{
    public class StudentController : Controller
    {

        Database1Entities db = new Database1Entities();

        // GET: Student
        public ActionResult Student(tbl_Student s)
        {
            if (s != null)
            {
                return View(s);
            }
            return View();
        }



        [HttpPost]
        public ActionResult AddStudent(tbl_Student model)
        {
            tbl_Student s = new tbl_Student
            {
                Name = model.Name,
                Fame = model.Fame,
                Email = model.Email,
                Mobile = model.Mobile,
                Description = model.Description
            };
            db.tbl_Student.Add(s);
            db.SaveChanges();
            ModelState.Clear();

            return View("Student");
        }


        public ActionResult StudentList()
        {
            var r = db.tbl_Student.ToList();
            return View(r);
        }



        public ActionResult Delete(int id)
        {
            var r = db.tbl_Student.Where(x => x.Id == id).First();
            db.tbl_Student.Remove(r);
            db.SaveChanges();

            var list = db.tbl_Student.ToList();

            return View("StudentList", list);

        }



    }
}