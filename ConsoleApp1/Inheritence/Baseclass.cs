using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritence
{
    internal class Baseclass
    {
        public void Addition()
        {
            int a = 12;
            int b = 13;
            int c = a + b;
            Console.WriteLine(c+" is the value of a and b after addition");
        }
        public void Multipliaction()
        {
            int a = 12;
            int b = 6;
            int c = a * b;
            Console.WriteLine(c+" is the value of a and b after multiplying");   
        }
    }
}
