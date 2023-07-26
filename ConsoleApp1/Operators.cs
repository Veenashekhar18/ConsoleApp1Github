using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Operators
    {
        public void ArthematicOperation()
        {
            int a = 12;
            int b = 6;
            Console.WriteLine("the addition of two numbers is " + (a + b) + " " + (a += b));
            Console.WriteLine(" the substcation of two numbers is " + (a - b) + " " + (a -= b));
            Console.WriteLine("the Mulplication of two numbers is " + (a * b) + " " + (a += b));
            Console.WriteLine(" the division of two numbers is " + (a / b) + " " + (a /= b));
            Console.WriteLine("the modulus of two numbers is " + (a % b) + " " + (a %= b));
            Console.WriteLine("increment the value from b" + b++);
            Console.WriteLine("decremnt the value of b" + b--);
            Console.WriteLine(" or operation i.e adding " + (a | b));
            Console.WriteLine(" and operation i.e multiplication " + (a & b));
        }
        public void Comparisionoperation()
        {
            int a = 12;
            int b = 6;
            Console.WriteLine(" xor oeration " + (a ^ b));
            Console.WriteLine(" returs true if a value is greater than b " + (a > b));
            Console.WriteLine(" right shift operator " + (a >> b));
            Console.WriteLine(" left shift operator " + (a << b));
            Console.WriteLine(" cmplement operation " + (~a));
            Console.WriteLine(" equals operation " + (a == 12));
            Console.WriteLine(" not equals operation " + (a != 6));
        }
        
        public void Logicaloperation()
        {
            int a = 12;
            int b = 6;
            Console.WriteLine(" or operation i.e adding " + (a | b));
            Console.WriteLine(" and operation i.e multiplication " + (a & b));

        }
        

    }
}
