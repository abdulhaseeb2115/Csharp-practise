using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InputLibrary;

namespace InputLibrary
{
    class Class1
    {
        static void Main(string[] args)
        {
            GetInput a = new GetInput();
            double x = a.GetDouble("Enter Age : ", " Invalid Input !!!\n");
            Console.WriteLine("Your Age is : " + x);
            Console.ReadKey();

        }
    }
}
