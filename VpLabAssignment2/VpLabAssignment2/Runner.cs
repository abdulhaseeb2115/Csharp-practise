using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VpLabAssignment2
{
    class Runner
    {
        static void Main(string[] args)
        {
            ///Question no 1///
            {
                //DayCollection week = new DayCollection();
                //System.Console.WriteLine(week["Fri"]);
                //// Raises ArgumentOutOfRangeException 
                //System.Console.WriteLine(week["Made-up Day"]);
                //// Keep the console window open in debug mode. 
                //System.Console.WriteLine("Press any key to exit.");
            }


            ///Question no 2///
            {
                //Program1 name = new Program1();
                //System.Console.WriteLine(name[0]);
                //System.Console.WriteLine(name[1.5f]);
                //System.Console.WriteLine(name[2.9]);
                //System.Console.WriteLine(name["aaa"]);
                //name[0] = "mmmm";
                //System.Console.WriteLine(name[0]);
            }


            ///Question no 3///
            {
                //operation op1 = new operation(Program2.Sq);
                //operation op2 = new operation(Program2.Sin);
                //operation op3 = new operation(Program2.Cos);


                //Console.WriteLine("Sqaure = " + op1(2));
                //Console.WriteLine("Cos x = " + op2(45));
                //Console.WriteLine("Sin = " + op3(90));
            }


            ///Question no 4///
            {
                //operationMulti opMulti1 = new operationMulti(Program3.Sq);
                //operationMulti opMulti2 = new operationMulti(Program3.Sin);
                //operationMulti opMulti3 = new operationMulti(Program3.Cos);
                //operationMulti choice = null;

                //int x;
                //try
                //{
                //    Console.Write("0.Sqaure\n1.Sin\n2.Cos\nChoose an Operation:");
                //    x = int.Parse(Console.ReadLine());
                //    switch (x)
                //    {
                //        case 0:
                //            choice += opMulti1;
                //            break;
                //        case 1:
                //            choice += opMulti2;
                //            break;
                //        case 2:
                //            choice += opMulti3;
                //            break;
                //        default:
                //            Console.WriteLine("Invalid Input !");
                //            break;
                //    }
                //}
                //catch (FormatException)
                //{
                //    Console.WriteLine("Invalid Input !");
                //}
                //catch (Exception)
                //{
                //    Console.WriteLine("An Error Occurred !");
                //}
                //choice();
            }



            System.Console.ReadKey();
        }
    }
}
