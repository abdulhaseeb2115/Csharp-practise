using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mids_prep
{
    class _events
    {
        class EventProgram
        {

            public delegate string MyDel(string str);
            event MyDel MyEvent;

            public EventProgram()
            {
                MyEvent += new MyDel(this.WelcomeUser);
            }
            

            public string WelcomeUser(string username)
            {
                return "Welcome " + username;
            }


            public static void Main(string[] args)
            {

                EventProgram obj1 = new EventProgram();
                string result = obj1.MyEvent("Tutorials Point");
                Console.WriteLine(result);

            }
        }
    }
}
