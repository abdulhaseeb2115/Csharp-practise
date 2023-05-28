using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
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

namespace DBProblem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UpdateTable();
        }


        private void UpdateTable()
        {


            CheckDbEntities db = new CheckDbEntities();
            var r = from d in db.Data select d;

            dg.ItemsSource = r.ToList();

            //PractiseDBEntities db = new PractiseDBEntities();
            //var r = from d in db.Doctors select d;
            //dg.ItemsSource = r.ToList();

            //string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\1_UNI\Programming\C#\DBProblem\DBProblem\PractiseDB.mdf;Integrated Security=True;Connect Timeout=30";
            //SqlConnection con = new SqlConnection(connectionstring);
            //string cmdstring;
            //using (SqlConnection con2 = new SqlConnection(connectionstring))
            //{
            //    cmdstring = "SELECT * FROM Doctor";
            //    SqlCommand cmd = new SqlCommand(cmdstring, con);
            //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable("Test");
            //    sda.Fill(dt);
            //    dg.ItemsSource = dt.DefaultView;
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\1_UNI\Programming\C#\DBProblem\DBProblem\PractiseDB.mdf;Integrated Security=True;Connect Timeout=30";
            //SqlConnection con = new SqlConnection(connectionstring);
            //if (con != null && con.State == ConnectionState.Closed)
            //{
            //    con.Open();
            //}
            //string query = @"INSERT INTO Doctor (Name,Designation,Specialization) VALUES (@program, @class, @subject)";
            //SqlCommand sqlcom = new SqlCommand(query, con);
            //sqlcom.CommandType = CommandType.Text;
            //sqlcom.Parameters.AddWithValue("@program", "hafeez");
            //sqlcom.Parameters.AddWithValue("@class", "none");
            //sqlcom.Parameters.AddWithValue("@subject", "yess");
            //sqlcom.ExecuteNonQuery();

            //MessageBox.Show("Data entered successfully");

            //PractiseDBEntities db = new PractiseDBEntities();

            //Doctor d = new Doctor
            //{
            //    Name = "jOHAR kHAN",
            //    Designation = "Good",
            //    Specialization = "Yess"
            //};
            //db.Doctors.Add(d);

            CheckDbEntities db = new CheckDbEntities();

            Datum d = new Datum {
                
            };
            db.Data.Add(d);

            db.SaveChanges();


            UpdateTable();
        }
    }


}