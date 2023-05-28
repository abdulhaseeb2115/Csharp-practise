using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VpLabAssignment2
{
    ///QUESTION NO 3///

    delegate double operation(double x);

    class Program2
    {
        public static double Sq(double a)
        {

            return Math.Pow(a, 2);
        }

        public static double Sin(double a)
        {
            return Math.Sin(a);
        }

        public static double Cos(double a)
        {
                return Math.Cos(a);
        }
    }
}
