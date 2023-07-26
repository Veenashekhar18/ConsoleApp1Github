using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.encapsulation
{
    public class EncapsulationDemo1
    {
        private string a = "karnataka";
        public String getmethod
        {
            get { return a; }
            set { a = value; }
        }
        public String getm()
        {
            return a;
        }
        public void setm(String a)
        {
            a = "hello";
        }
        public string messege { get; set; }

    }
    public class Method1 : EncapsulationDemo1
    {
        public void getm()
        {
            Console.WriteLine(getmethod);
            messege = "hello world";
            Console.WriteLine(messege);
            Console.WriteLine("===============");
            Console.WriteLine(messege);
            Console.WriteLine("hello seoul");
            Console.WriteLine(messege);

        }

    }
}
