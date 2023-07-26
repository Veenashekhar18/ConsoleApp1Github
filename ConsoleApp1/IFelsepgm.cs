using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class IFelsepgm
    {
        public void Condition()
        {
            int a = 25;
            int b = 15;
            if(a>b)
            {
                Console.WriteLine(a+" is bigger than "+b);
            }
            else if(b>a)
                    {
                Console.WriteLine(b+" is bigger than "+a);
            }
            int c=(a>b)?a:b;
            Console.WriteLine(c+" a is bigger than b");
        }
    }
}
