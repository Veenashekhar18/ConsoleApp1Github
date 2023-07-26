using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.constructor
{
    public class Constructorchaining
    {
        string a = "Doremon";
        public Constructorchaining()
        {
            Console.WriteLine("this constructor is not parameterized");
        }
        public Constructorchaining(string a)
        {
            Console.WriteLine("this is parameterized constructor");
        }
    }
    public class Implement : Constructorchaining
    {
        public Implement() : base()
        {
            Console.WriteLine("nobita");
            Constructorchaining c = new Constructorchaining("hii");
        }
       
            

        
    }

}
