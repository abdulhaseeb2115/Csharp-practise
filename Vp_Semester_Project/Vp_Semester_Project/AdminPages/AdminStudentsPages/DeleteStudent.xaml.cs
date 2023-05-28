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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Vp_Semester_Project.BackendClasses.AdminBackend;

namespace Vp_Semester_Project.AdminPages.AdminStudentsPages
{
    /// <summary>
    /// Interaction logic for DeleteStudent.xaml
    /// </summary>
    public partial class DeleteStudent : Page
    {
        public DeleteStudent()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            if (InputRegNo.Text != "")
            {
                try
                {
                    string batchS = InputRegNo.Text.Substring(0, 2).ToUpper();
                    int batchY = int.Parse(InputRegNo.Text.Substring(2, 2).ToUpper());
                    int rollNo = int.Parse(InputRegNo.Text.Substring(9));

                    AdminStudentBackend backend = new AdminStudentBackend();
                    string[] studentData = backend.ViewStudent(batchS, batchY, rollNo);
                    if (studentData.Length == 1)
                    {
                        clearVisibility();
                        noDataLabel.Content = studentData[0];

                        noData.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        clearVisibility();
                        SerialNoOutput.Content = "ST - " + studentData[0];
                        RegNoOutput.Content = studentData[1];
                        ClassOutput.Content = studentData[2];
                        NameOutput.Content = studentData[4];
                        FatherNameOutput.Content = studentData[5];

                        foundData.Visibility = Visibility.Visible;
                    }

                }
                catch (Exception)
                {
                    clearVisibility();
                    noDataLabel.Content = "Invalid Reg No !";
                    noData.Visibility = Visibility.Visible;
                }
            }
        }

        private void clearVisibility()
        {
            noData.Visibility = Visibility.Hidden;
            foundData.Visibility = Visibility.Hidden;
            SerialNoOutput.Content = "";
            message.Text = "";
        }

        private void clearFields()
        {
            InputRegNo.Text = "";
            SerialNoOutput.Content = "";
            RegNoOutput.Content = "";
            ClassOutput.Content = "";
            NameOutput.Content = "";
            FatherNameOutput.Content = "";
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (SerialNoOutput.Content.ToString() != "")
            {
                try
                {
                    AdminStudentBackend backend = new AdminStudentBackend();
                    message.Text = backend.DeleteStudent(int.Parse(SerialNoOutput.Content.ToString().Substring(5)));
                    clearFields();
                }
                catch (Exception e1)
                {
                    clearFields();
                    message.Text = e1.ToString();
                    //Clipboard.SetText(e1.ToString());
                    message.Text = "An Error Occured !";
                }
            }
        }
    }
}
