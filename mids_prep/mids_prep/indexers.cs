using mids_prep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mids_prep
{
    class indexers
    {
        private int[] nums = new int[5];

        public int this[int index]
        {
            get { return nums[index]; }
            set { nums[index] = value; }
        }

    }



    //class main
    //{
    //    public static void Main()
    //    {
    //        //---Indexer---//
    //        indexers idxr = new indexers();


    //        idxr[0] = 1;
    //        idxr[1] = 22;
    //        idxr[2] = 333;
    //        idxr[3] = 444;

    //        Console.WriteLine(idxr[0]);
    //        Console.WriteLine(idxr[1]);
    //        Console.WriteLine(idxr[2]);
    //        Console.WriteLine(idxr[3]);

    //        Console.ReadKey();
    //    }
    //}

}