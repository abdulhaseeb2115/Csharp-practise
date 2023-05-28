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

namespace MateenAss
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Student[,] classRoom = new Student[3, 3];

        public MainWindow()
        {
            InitializeComponent();

            Student o1 = new Student()
            {
                roll = "90",
                className = "BSE1"
            };
            Student o2 = new Student()
            {
                roll = "91",
                className = "BSE2"
            };
            Student o3 = new Student()
            {
                roll = "91",
                className = "BSE3"
            };
            Student o4 = new Student()
            {
                roll = "91",
                className = "BSE4"
            };
            Student o5 = new Student()
            {
                roll = "91",
                className = "BSE1"
            };
            Student o6 = new Student()
            {
                roll = "91",
                className = "BSE2"
            };
            Student o7 = new Student()
            {
                roll = "91",
                className = "BSE3"
            };
            Student o8 = new Student()
            {
                roll = "91",
                className = "BSE4"
            };
            Student o9 = new Student()
            {
                roll = "91",
                className = "BSE5"
            };


            Student[] studentList = { o1, o2, o3, o4, o5, o6, o7, o8, o9};

            for (int i = 0; i < studentList.Length; i++)
            {
                assign(studentList[i]);
            }

            print();
        }

        //        [ J ]    [ J+1 ]     [ J+2 ]
        //
        //  [I]   (i,j)    (i,j+1)     (i,j+2)
        //[I+1]   (i+1,j)  (i+1,j+1)   (i+1,j+2)
        //[I+2]   (i+2,j)  (i+2,j+1)   (i+2,j+2)


        public void assign(Student a)
        {
            for (int r = 0; r < classRoom.GetLength(0); r++)
            {
                for (int c = 0; c < classRoom.GetLength(1); c++)
                {
                    if (classRoom[r, c] == null)
                    {
                        if (c == 0)
                        {
                            if (r == 0)
                            {
                                //rx+1 cy, rx cy+1
                                if ((classRoom[r + 1, c] == null || classRoom[r + 1, c].className != a.className) &&
                                    (classRoom[r, c + 1] == null || classRoom[r, c + 1].className != a.className))
                                {
                                    classRoom[r, c] = a;
                                    a.seat = r+","+c;
                                    return;
                                }
                            }
                            else if (r == classRoom.GetLength(0) - 1)
                            {
                                //rx-1 cy, rx cy+1
                                if ((classRoom[r - 1, c] == null || classRoom[r - 1, c].className != a.className) &&
                                        (classRoom[r, c + 1] == null || classRoom[r, c + 1].className != a.className))
                                {
                                    classRoom[r, c] = a;
                                    a.seat = r+","+c;
                                    return;
                                }

                            }
                            else
                            {
                                if ((classRoom[r - 1, c] == null || classRoom[r - 1, c].className != a.className) &&
                                        (classRoom[r + 1, c] == null || classRoom[r + 1, c].className != a.className) &&
                                        (classRoom[r, c + 1] == null || classRoom[r, c + 1].className != a.className))
                                {
                                    classRoom[r, c] = a;
                                    a.seat = r+","+c;
                                    return;
                                }
                            }
                        }
                        else if (c == classRoom.GetLength(1) - 1)
                        {
                            if (r == 0)
                            {
                                //rx+1 cy, rx cy-1
                                if ((classRoom[r + 1, c] == null || classRoom[r + 1, c].className != a.className) &&
                                            (classRoom[r, c - 1] == null || classRoom[r, c - 1].className != a.className))
                                {
                                    classRoom[r, c] = a;
                                    a.seat = r+","+c;
                                    return;
                                }
                            }
                            if (r == classRoom.GetLength(0) - 1)
                            {
                                //rx-1 cy, rx cy-1
                                if ((classRoom[r - 1, c] == null || classRoom[r - 1, c].className != a.className) &&
                                    (classRoom[r, c - 1] == null || classRoom[r, c - 1].className != a.className))
                                {
                                    classRoom[r, c] = a;
                                    a.seat = r+","+c;
                                    return;
                                }

                            }
                            else
                            {
                                if ((classRoom[r - 1, c] == null || classRoom[r - 1, c].className != a.className) &&
                                        (classRoom[r + 1, c] == null || classRoom[r + 1, c].className != a.className) &&
                                        (classRoom[r, c - 1] == null || classRoom[r, c - 1].className != a.className))
                                {
                                    classRoom[r, c] = a;
                                    a.seat = r+","+c;
                                    return;
                                }
                            }
                        }
                        else if (r == 0)
                        {
                            if ((classRoom[r + 1, c] == null || classRoom[r + 1, c].className != a.className) &&
                                (classRoom[r, c - 1] == null || classRoom[r, c - 1].className != a.className) &&
                                (classRoom[r, c + 1] == null || classRoom[r, c + 1].className != a.className))
                            {
                                classRoom[r, c] = a;
                                a.seat = r+","+c;
                                return;
                            }
                        }
                        else if (r == classRoom.GetLength(0) - 1)
                        {
                            if ((classRoom[r - 1, c] == null || classRoom[r - 1, c].className != a.className) &&
                                (classRoom[r, c - 1] == null || classRoom[r, c - 1].className != a.className) &&
                                (classRoom[r, c + 1] == null || classRoom[r, c + 1].className != a.className))
                            {
                                classRoom[r, c] = a;
                                a.seat = r+","+c;
                                return;
                            }
                        }
                        else
                        {
                            if ((classRoom[r + 1, c] == null || classRoom[r + 1, c].className != a.className) &&
                                (classRoom[r - 1, c] == null || classRoom[r - 1, c].className != a.className) &&
                                (classRoom[r, c - 1] == null || classRoom[r, c - 1].className != a.className) &&
                                (classRoom[r, c + 1] == null || classRoom[r, c + 1].className != a.className))
                            {
                                classRoom[r, c] = a;
                                a.seat = r+","+c;
                                return;
                            }
                        }
                    }
                }
            }
        }

        public void print()
        {
            string str = "";
            for (int i = 0; i < classRoom.GetLength(0); i++)
            {
                for (int j = 0; j < classRoom.GetLength(1); j++)
                {
                    if (classRoom[i, j] != null)
                    {
                        str += classRoom[i, j].className + "("+ classRoom[i, j].seat+")  ";
                    }
                    else
                    {
                        str += "x        ";
                    }
                }
                str += "\n";
            }
            ans.Text = str;
        }


    }
}