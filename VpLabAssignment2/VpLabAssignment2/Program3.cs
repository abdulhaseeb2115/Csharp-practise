using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VpLabAssignment2
{
    ///QUESTION NO 4///

    delegate void operationMulti();

    class Program3
    {
        public static void Sq()
        {
            int x;
            do
            {
                try
                {
                    Console.Write("Enter a number: ");
                    x = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input !");
                }
                catch (Exception)
                {
                    Console.WriteLine("An Error Occurred !");
                }
            } while (true);
            Console.WriteLine(Math.Pow(x, 2));
        }

        public static void Sin()
        {
            int x;
            do
            {
                try
                {
                    Console.Write("Enter a number: ");
                    x = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input !");
                }
                catch (Exception)
                {
                    Console.WriteLine("An Error Occurred !");
                }
            } while (true);
            Console.WriteLine(Math.Sin(x));
        }

        public static void Cos()
        {
            int x;
            do
            {
                try
                {
                    Console.Write("Enter a number: ");
                    x = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input !");
                }
                catch (Exception)
                {
                    Console.WriteLine("An Error Occurred !");
                }
            } while (true);

            Console.WriteLine(Math.Sqrt(x));
        }

    }
}

