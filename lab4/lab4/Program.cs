using System;

namespace lab4
{
    class Program
    {
        /*   static void Main(string[] args)
           {
               double a = 98, b = 0;
               double result = 0;
               try
               {

                   result = SafeDivision(a, b);
                   Console.WriteLine("{0} divided by {1} = {2}", a, b,
                  result);
               }
               catch (DivideByZeroException e)
               {
                   Console.WriteLine("Attempted divide by zero.");
               }
           }

           static double SafeDivision(double x, double y)
           {
               if (y == 0)
                   throw new System.DivideByZeroException();
               return x / y;
           }
        */



        /*   static void Main(string[] args)
           {
               TestCatch2();
           }


           static void TestCatch2()
           {
               System.IO.StreamWriter sw = null;
               try
               {
                   sw = new System.IO.StreamWriter(@"D:\test.txt");
                   sw.WriteLine("Hello");
                   for (int i = 0; i < 10; i++)
                   {
                       sw.WriteLine(i * 10);
                   }
               }
               catch (System.IO.FileNotFoundException ex)
               {
                   // Put the more specific exception first.
                   //System.Console.WriteLine(ex.ToString());
               }
               catch (System.IO.IOException ex)
               {
                   // Put the less specific exception last.
                   //System.Console.WriteLine(ex.ToString());
               }
               catch (System.UnauthorizedAccessException ex)
               {
                   // Put the less specific exception last.
                   System.Console.WriteLine(ex.ToString());
               }
               finally
               {
                   if (sw != null)
                       sw.Close();
               }
               System.Console.WriteLine("Done");
           }
        */
    }
}

/*
class TempRecord
{
    private float[] temps = { 56.2F, 56.7F, 56.5F, 56.9F, 58.8F, 61.3F, 65.9F, 62.1F, 59.2F, 57.5F };

    public int Length
    {
        get { return temps.Length; }
    }

    public float this[int index]
    {
        get
        {
            return temps[index];
        }
        set
        {
            temps[index] = value;
        }
    }
}
class MainClass
{
    static void Main()
    {
        TempRecord tempRecord = new TempRecord();

        tempRecord[3] = 600.3F;
        tempRecord[5] = 601.1F;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Element #{0} = {1}", i, tempRecord[i]);
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
*/

/*
class SampleCollection<T>
{
    private T[] arr = new T[100];
    public T this[int i]
    {
        get
        {
            return arr[i];
        }
        set
        {
            arr[i] = value;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        //SampleCollection<string> stringCollection = new SampleCollection<string>();
        SampleCollection<int> stringCollection = new SampleCollection<int>();
        //stringCollection[0] = "Hello, World";
        stringCollection[0] = 123;
        Console.WriteLine(stringCollection[0]);
    }
}
*/



