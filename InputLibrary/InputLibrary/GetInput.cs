using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputLibrary
{
    class GetInput
    {

        //INT
        public int GetInt(string inputMessage, string errorMessage)
        {
            int i;
            do
            {
                try
                {
                    Console.Write(inputMessage);
                    i = int.Parse(Console.ReadLine());

                    return i;
                }
                catch
                {
                    Console.WriteLine(errorMessage);
                }
            } while (true);
        }

        //FLOAT
        public float GetFloat(string inputMessage, string errorMessage)
        {
            float i;
            do
            {
                try
                {
                    Console.Write(inputMessage);
                    i = float.Parse(Console.ReadLine());

                    return i;
                }
                catch
                {
                    Console.WriteLine(errorMessage);
                }
            } while (true);
        }

        //DOUBLE
        public double GetDouble(string inputMessage, string errorMessage)
        {
            double i;
            do
            {
                try
                {
                    Console.Write(inputMessage);
                    i = double.Parse(Console.ReadLine());

                    return i;
                }
                catch
                {
                    Console.WriteLine(errorMessage);
                }
            } while (true);
        }

        //LONG
        public long GetLong(string inputMessage, string errorMessage)
        {
            long i;
            do
            {
                try
                {
                    Console.Write(inputMessage);
                    i = long.Parse(Console.ReadLine());

                    return i;
                }
                catch
                {
                    Console.WriteLine(errorMessage);
                }
            } while (true);
        }
        
        //SHORT
        public short GetShort(string inputMessage, string errorMessage)
        {
            short i;
            do
            {
                try
                {
                    Console.Write(inputMessage);
                    i = short.Parse(Console.ReadLine());

                    return i;
                }
                catch
                {
                    Console.WriteLine(errorMessage);
                }
            } while (true);
        }

        //STRING
        public string GetString(string inputMessage, string errorMessage)
        {
            string i;
            do
            {
                try
                {
                    Console.Write(inputMessage);
                    i = Console.ReadLine();

                    return i;
                }
                catch
                {
                    Console.WriteLine(errorMessage);
                }
            } while (true);
        }

        //CHAR
        public char GetChar(string inputMessage, string errorMessage)
        {
            char i;
            do
            {
                try
                {
                    Console.Write(inputMessage);
                    i = char.Parse(Console.ReadLine());

                    return i;
                }
                catch
                {
                    Console.WriteLine(errorMessage);
                }
            } while (true);

        }





    }
}
