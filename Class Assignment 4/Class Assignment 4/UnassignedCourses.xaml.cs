﻿using System;
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
using System.Windows.Shapes;

namespace Class_Assignment_4
{
    /// <summary>
    /// Interaction logic for UnassignedCourses.xaml
    /// </summary>
    public partial class UnassignedCourses : Window
    {
        public UnassignedCourses()
        {
            InitializeComponent();
            assignDBEntities db = new assignDBEntities();
            //var x = from d in db.StudentCourseRelations 
            //        join s in db.Students on d.StudentID equals s.Id 
            //        join c in db.Courses on d.CourseID equals c.Id
            //        select new {c.Name };
            //var y = from d in db.Courses select new { d.Name };
            //var z = y.Except(x);
            //myData.ItemsSource = z.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Courses c = new Courses();
            c.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow c = new MainWindow();
            c.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //UnassignedStudents c = new UnassignedStudents();
            //c.Show();
            //this.Close();
        }
    }
}
