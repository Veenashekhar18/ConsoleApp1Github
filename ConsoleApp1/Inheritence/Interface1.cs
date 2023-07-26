using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritence
{
    internal interface Interface1
    {
         void Demo();
        void Demo1();

    }
    public class Inter : Interface1
    {
        public void Demo()
        {
            Console.WriteLine("hello hii");
        }
        public void Demo1()
        {
            Console.WriteLine("hello bengaluru");
        }
    }

}
