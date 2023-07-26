using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritence
{
    internal class Methodoverload
    {
        public static void main(string a)
        {
            Console.WriteLine("only Strings");
        }
        public static void main(string b,int c) 
        {
            Console.WriteLine("numbers and String");
        }
        public static void main(float d,long e) 
        {
            Console.WriteLine("float value and long value");
        }
    }
     


    }


