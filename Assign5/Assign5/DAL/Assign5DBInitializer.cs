using Assign5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assign5.DAL
{
    public class Assign5DBInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<Assign5DBContext>
    {
        protected override void Seed(Assign5DBContext db)
        {
            List<Child> c = new List<Child>
            {
                new Child{name="aslam",age=20},
                new Child{name="ahmad",age=25}
            };

            List<Departments> d = new List<Departments>
            {
                new Departments{dno=1,dname="BBA",budget=600},
                new Departments{dno=2,dname="SE",budget=700}
            };

            List<Employees> e = new List<Employees>
            {
                new Employees{ssn="111-222-333",phone="0300000",salary=1000,department=d.ToList()[0],child=c.ToList()[0]},
                new Employees{ssn="444-555-666",phone="111111",salary=2000,department=d.ToList()[1],child=c.ToList()[1]},
            };

            foreach (var item in c)
            {
                db.Child.Add(item);
            }
            db.SaveChanges();


            foreach (var item in d)
            {
                db.Departments.Add(item);
            }
            db.SaveChanges();


            foreach (var item in e)
            {
                db.Employees.Add(item);
            }
            db.SaveChanges();

        }
    }
}