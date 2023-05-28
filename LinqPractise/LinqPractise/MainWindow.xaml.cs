using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LinqPractise
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //PractiseDBEntities1 db = new PractiseDBEntities1();

            //Doctor d = new Doctor
            //{
            //    Name = "xxx",
            //    Designation = "pojij",
            //    Specialization = "none"
            //};

            //db.Doctors.Add(d);
            //db.SaveChanges();


            PractiseDBEntities1 db1 = new PractiseDBEntities1();
            var r = from doc in db1.Doctors select doc;

            dataGrid.ItemsSource = r.ToList();


            //Join

            //var r = from a in db.Appointments
            //        join d in db.Doctors on a.dID equals d.Id
            //        join p in db.Patients on a.pID equals p.Id
            //        select new
            //        {
            //            DoctorName = d.Name,
            //            PatientName = p.Name,
            //            Appointmentdate = a.AppointmentDate
            //        };


            // Left Join

            //var r = from d in db.Doctors
            //        join a in db.Appointments
            //        on d.Id equals a.dID
            //        into t
            //        from rt in t.DefaultIfEmpty()
            //        orderby d.Name
            //        select new
            //        {
            //            d.Name,
            //            rt.AppointmentDate
            //        };


            //Cross Join

            //var r = from d in db.Doctors
            //        from a in db.Appointments
            //        select new
            //        {
            //            d.Name,
            //            a.AppointmentDate
            //        };


            //Group Join

            //var r = from d in db.Doctors
            //        join a in db.Appointments 
            //        on d.Id equals a.dID
            //        into t
            //        from rt in t.DefaultIfEmpty()
            //        select new
            //        {
            //            DoctorName=d.Name,
            //            Appointments=rt.AppointmentDate
            //        };



            ////////////////
            // NAVIGATION //
            ////////////////

            // Join

            //var r = from a in db.Appointments
            //        select new
            //        {
            //            a.Id,
            //            Patient = a.Patient.Name,
            //            Doctor = a.Doctor.Name,
            //            a.AppointmentDate,
            //        };


            // Outer Join

            //var r = from d in db.Doctors
            //        from a in d.Appointments.DefaultIfEmpty()
            //        select new
            //        {
            //            AppointmentID = a.Id.ToString(),
            //            Doctor = d.Name,
            //            a.AppointmentDate,
            //};





            //dataGrid.ItemsSource = r.ToList();

        }


    }
}
