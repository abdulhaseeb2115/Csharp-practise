using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VpLabAssignment2
{
    ///QUESTION NO 2///
    class Program1
    {
        private string[] nameArr = { "aaa", "bbb", "ccc", "ddd" };

        //Int
        public string this[int index]
        {

            get
            {
                return nameArr[index];
            }
            set
            {
                for (int i = 0; i < nameArr.Length; i++)
                {
                    if (nameArr.Contains(value))
                    {
                        Console.WriteLine("Duplicate Names Not Allowed !");
                        break;
                    }
                    else
                    {
                        nameArr[index] = value;
                    }
                }
            }
        }

        //Float
        public string this[float index]
        {
            get
            {
                int index1 = 0;
                try
                {
                    index1 = Convert.ToInt32(Math.Floor(index));
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
                return nameArr[index1];
            }
        }

        //Double
        public string this[double index]
        {
            get
            {
                int index1 = 0;
                try
                {
                    index1 = Convert.ToInt32(Math.Floor(index));
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
                return nameArr[index1];
            }
        }

        //Long
        public string this[long index]
        {
            get
            {
                try
                {
                    index = Convert.ToInt32(index);
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
                return nameArr[index];
            }
        }

        //String
        public string this[string index]
        {
            get
            {
                for (int i = 0; i < nameArr.Length; i++)
                {
                    if (nameArr[i].Contains(index))
                    {
                        return "Found";
                    }
                }
                return "Not Found";
            }

        }
    }
}
