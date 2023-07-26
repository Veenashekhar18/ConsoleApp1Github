using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pattern
    {
        public static void pattern()
        {
            for (int i = 1; i<=4; i++)
            {
                for (int j = 1; j<=4; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine(" ");
        }
       
        }
    }
}
