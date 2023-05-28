using System;

namespace practise
{

    //////////////////////
    ///// PROPERTIES /////
    //////////////////////
    class Property
    {
        private string name;

        // property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    //////////////////////
    /////  INDEXERS  /////
    //////////////////////
    class Indexer
    {

        private string[] arr = new string[3];
        // indexer
        public string this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
    }


    //////////////////////
    //////// MAIN ////////
    //////////////////////
    class Program
    {
        static void Main(string[] args)
        {
            //Property p = new Property();
            //p.Name = "ABH";
            //Console.WriteLine(p.Name);

            //Indexer i = new Indexer();
            //i[0] = "A";
            //i[1] = "AB";
            //i[2] = "ABC";
            //Console.WriteLine(" First value = {0} \n Second value = {1} \n Third value = {2}", i[0], i[1], i[2]);




        }
    }
}
