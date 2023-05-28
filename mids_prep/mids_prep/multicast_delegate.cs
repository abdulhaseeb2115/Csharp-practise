using mids_prep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static mids_prep.multicast_delegate;

namespace mids_prep
{
    class multicast_delegate
    {
        public delegate void mdelegate(int x);

        public void first(int x)
        {
            Console.WriteLine("First-> " + x);
        }
        public void second(int x)
        {
            Console.WriteLine("Second-> " + x);
        }

    }



    //class main
    //{
    //    public static void Main()
    //    {
    //        multicast_delegate mcd = new multicast_delegate();

    //        mdelegate md = new mdelegate(mcd.first);

    //        md += mcd.second;
    //        md(10);

    //        Console.ReadKey();
    //    }
    //}
}

