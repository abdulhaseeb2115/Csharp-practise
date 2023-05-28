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

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double num_1 = 0f;
        double num_2 = 0f;
        string operation = "";



        public MainWindow()
        {
            InitializeComponent();
        }


        private void clear_Click(object sender, RoutedEventArgs e)
        {
            num_1 = num_2 = 0;
            operation = screen.Text=historyScreen.Text = "";
        }

        private void backspace_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num_1 = (int)(num_1 / 10);
                screen.Text = num_1.ToString();
            }
            else
            {
                num_2 = (int)(num_2 / 10);
                screen.Text = num_2.ToString();
            }
        }


        // Numbers Click //
        private void num_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            double x = double.Parse(b.Content.ToString());
            if (operation == "")
            {
                num_1 = (num_1 * 10) + x;
                screen.Text = num_1.ToString();
            }
            else
            {
                num_2 = (num_2 * 10) + x;
                screen.Text = num_2.ToString();
            }
        }

        // Operators Click //
        private void operator_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Content.ToString();
            screen.Text = "0";
        }

 // Square //
        private void square_Click(object sender, RoutedEventArgs e)
        {
            if (num_1 != 0)
            {
                double ans = Math.Pow(num_1, 2);
                historyScreen.Text = num_1 + "²";
                screen.Text = ans.ToString();
                num_1 = ans;
                num_2 = 0;
            }
        }

        // Cube //
        private void cube_Click(object sender, RoutedEventArgs e)
        {
            if (num_1 != 0)
            {
                double ans = Math.Pow(num_1, 3);
                historyScreen.Text = num_1 + "³";
                screen.Text = ans.ToString();
                num_1 = ans;
                num_2 = 0;
            }
        }

        // 1/x //
        private void reciprocal_Click(object sender, RoutedEventArgs e)
        {
            if (num_1 != 0)
            {
                double ans = 1 / num_1;
                historyScreen.Text =1+"/"+ num_1;
                screen.Text = (ans).ToString();
                num_1 = ans;
                num_2 = 0;
            }
        }

        // Square Root //
        private void squareRoot_Click(object sender, RoutedEventArgs e)
        {
            if (num_1 != 0)
            {
                double ans = Math.Sqrt(num_1);
                historyScreen.Text = "√" + num_1;
                screen.Text = (ans).ToString();
                num_1 = ans;
                num_2 = 0;
            }
        }

        // Factorial //
        private void factorial_Click(object sender, RoutedEventArgs e)
        {
            int factorial = 1;
            for (int i = (int)num_1; i > 1; i--)
            {
                factorial *= i;
            }
            historyScreen.Text = num_1+"!";
            screen.Text = factorial.ToString();
            num_1 = factorial;
            num_2 = 0;
        }


        // Sin //
        private void sin_Click(object sender, RoutedEventArgs e)
        {
            double ans = Math.Sin(num_1);
            historyScreen.Text = "Sin(" + num_1+")";
            screen.Text = ans.ToString();
            num_1 = ans;
            num_2 = 0;
        }

        // Cos //
        private void cos_Click(object sender, RoutedEventArgs e)
        {
            double ans = Math.Cos(num_1);
            historyScreen.Text = "Cos(" + num_1 + ")";
            screen.Text = ans.ToString();
            num_1 = ans;
            num_2 = 0;
        }

        // Tan //
        private void tan_Click(object sender, RoutedEventArgs e)
        {
            double ans = Math.Tan(num_1);
            historyScreen.Text = "Tan(" + num_1 + ")";
            screen.Text = ans.ToString();
            num_1 = ans;
            num_2 = 0;
        }

        // Equals //
        private void equals_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "+")
            {
                historyScreen.Text = num_1 + " + " + num_2;
                screen.Text = (num_1 + num_2).ToString();
                num_1 = num_1 + num_2;
                num_2 = 0;
            }
            else if (operation == "-")
            {
                historyScreen.Text = num_1 + " - " + num_2;
                screen.Text = (num_1 - num_2).ToString();
                num_1 = num_1 - num_2;
                num_2 = 0;
            }
            else if (operation == "x")
            {
                historyScreen.Text = num_1 + " x " + num_2;
                screen.Text = (num_1 * num_2).ToString();
                num_1 = num_1 * num_2;
                num_2 = 0;
            }
            else if (operation == "÷")
            {
                if (num_2 != 0)
                {
                    historyScreen.Text = num_1 + " ÷ " + num_2;
                    screen.Text = (num_1 / num_2).ToString();
                    num_1 = num_1 / num_2;
                    num_2 = 0;
                }
                else
                {
                    MessageBox.Show("Cannot divide by zero !!!");
                    clear_Click(sender, e);
                }
            }
        }


    }
}
