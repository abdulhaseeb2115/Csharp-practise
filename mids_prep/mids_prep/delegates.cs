using mids_prep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static mids_prep.delegates;

namespace mids_prep
{
    class delegates
    {
        public delegate int addnum(int a, int b);
        public delegate void subnum(int a, int b);

        public int add(int a, int b)
        {
            return (a + b);

        }
        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }


    }

    //    class main2
    //    {
    //        public static void Main()
    //        {
    //            delegates d = new delegates();

    //            addnum sum = new addnum(d.add);
    //            subnum sub = new subnum(d.sub);

    //            Console.WriteLine(sum(5, 5));
    //            sub(150, 50);

    //            Console.ReadKey();
    //        }
    //    }
}
