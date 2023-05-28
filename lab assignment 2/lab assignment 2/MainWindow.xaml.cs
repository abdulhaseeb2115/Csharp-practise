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
using System.Xml;

namespace lab_assignment_2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        bool attr, elm = false;
        private void element_Checked(object sender, RoutedEventArgs e)
        {
            elm = true;
        }

        private void attribute_Checked(object sender, RoutedEventArgs e)
        {
            attr = true;
        }



        private void attribute_Unchecked(object sender, RoutedEventArgs e)
        {
            attr = false;
        }

        private void element_Unchecked(object sender, RoutedEventArgs e)
        {
            elm = false;
        }






        private void Button_Click(object sender, RoutedEventArgs e)
        {
            output.Text = "";
            try
            {
                do
                {
                    if (attr == false && elm == false)
                    {
                        MessageBox.Show("Check a CheckBox !!!");
                        break;
                    }
                    else if (input.Text.Equals(""))
                    {
                        MessageBox.Show("File Path Not Entered !!!");
                        break;
                    }
                    else
                    {
                        XmlTextReader readObj = new XmlTextReader(input.Text);
                        while (readObj.Read())
                        {
                            if (readObj.NodeType == XmlNodeType.Element)
                            {

                                if (elm == true)
                                {
                                    string str = readObj.Name;
                                    readObj.Read();
                                    if (!output.Text.Contains(str))
                                    {
                                        output.AppendText("\n" + str + " " + readObj.Value);
                                    }
                                }

                                if (attr == true)
                                {
                                    for (int i = 0; i < readObj.AttributeCount; i++)
                                    {
                                        readObj.MoveToAttribute(i);
                                        output.AppendText("\n" + readObj.Name + " " + readObj.Value);
                                    }
                                }
                            }
                        }

                        break;

                    }
                } while (true);



            }
            catch (XmlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occurred");
            }
        }
    }
}
