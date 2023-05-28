using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VpLabAssignment2
{
    ///QUESTION NO 1///
    class DayCollection
    {
        private string[] collectionArr = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        public int this[string index]
        {
            get
            {
                int dayNum = 0;
                bool found = false;

                for (int i = 0; i < collectionArr.Length; i++)
                {
                    if (collectionArr[i].Contains(index))
                    {
                        dayNum = i;
                        found = true;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("'" + index + "' was not Found !");
                }

                return dayNum;
            }
        }
    
    }
}
