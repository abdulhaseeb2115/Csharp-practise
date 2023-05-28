using mids_prep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mids_prep
{
    class _2dIndexers
    {
        int[,] arr = new int[2, 3];

        public int this[int index1, int index2]
        {
            get
            {
                return arr[index1, index2];
            }
            set
            {
                arr[index1, index2] = value;
            }
        }
    }

    //class main
    //{
    //public static void Main()
    //{
    //    _2dIndexers ind = new _2dIndexers();
    //    ind[0, 0] = 10;
    //    ind[0, 1] = 20;

    //    ind[1, 0] = 110;
    //    ind[1, 1] = 120;
    //    ind[1, 2] = 130;



    //    Console.WriteLine(ind[0, 0]);
    //    Console.WriteLine(ind[0, 1]);
    //    Console.WriteLine(ind[0, 2]);

    //    Console.WriteLine(ind[1, 0]);
    //    Console.WriteLine(ind[1, 1]);
    //    Console.WriteLine(ind[1, 2]);

    //    Console.ReadKey();
    //}

    //}



}
