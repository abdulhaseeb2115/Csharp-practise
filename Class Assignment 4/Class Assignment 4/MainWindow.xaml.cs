using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Class_Assignment_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            assignDBEntities db = new assignDBEntities();
            var x = from d in db.Students select d;
            myData.ItemsSource = x.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            assignDBEntities db = new assignDBEntities();
            Student s = new Student()
            {
                Name = Sname.Text,
                RegNo = Sreg.Text
            };
            db.Students.Add(s);
            db.SaveChanges();

            var x = from d in db.Students select d;
            myData.ItemsSource = x.ToList();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Courses c = new Courses();
            c.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            UnassignedCourses c = new UnassignedCourses();
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
