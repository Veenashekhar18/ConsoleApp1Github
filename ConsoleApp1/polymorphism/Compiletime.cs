using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.polymorphism
{
    internal class Compiletime
    {
        public void main(string a)
        {
            Console.WriteLine("only Strings");
        }
        public void main(string b, int c)
        {
            Console.WriteLine("numbers and String");
        }
        public void main(float d, long e)
        {
            Console.WriteLine("float value and long value");
        }
    }
}

