using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.abstraction
{
    public abstract class Abstract1
    {
        public abstract class Messege
        {
            public abstract void Hi1();
            public abstract void Hello1();
        }
        public class Sms : Messege

        {
            public override void Hi1()
            {
                Console.WriteLine("hiiiii");
            }
            public override void Hello1()
            {
                Console.WriteLine("hellooooo");
            }

        }
        public static void mainab()
        {
            Messege m = new Sms();
            m.Hi1();
            m.Hello1();
        }
    }
     
    

       
       
    }

