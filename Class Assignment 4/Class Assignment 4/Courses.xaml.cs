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
using System.Windows.Shapes;

namespace Class_Assignment_4
{
    /// <summary>
    /// Interaction logic for Courses.xaml
    /// </summary>
    public partial class Courses : Window
    {
        public Courses()
        {
            InitializeComponent();
            assignDBEntities db = new assignDBEntities();
            var x = from d in db.Courses select d;
            myData.ItemsSource = x.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            assignDBEntities db = new assignDBEntities();
            Cours c = new Cours()
            {
                Name = Cname.Text,
                Code=Ccode.Text
            };
            db.Courses.Add(c);
            db.SaveChanges();

            var x = from d in db.Courses select d;
            myData.ItemsSource = x.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }
    }
}
