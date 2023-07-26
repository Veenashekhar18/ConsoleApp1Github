using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Framework
{
    public interface Tejas
    {
        void Akash();
        void Vinay();
        void kiran();
        const string a = "google";
        static string b = "safari";
    } 
    public abstract class Datta : Tejas
    {
        public string book = "Atomic habits";
        public void Akash()
        {
            Console.WriteLine("methodoverridden in datta class");    
        }
        public virtual void Vinay()
        {
            Console.WriteLine("virtual methodoverridden in datta class");
        }
       
       public abstract void kiran();
        public Datta()
        {
            Console.WriteLine("this is constructor in datta class");
        }

    }
    public class Veena : Datta
    {
        public sealed override void kiran()
        {
            Console.WriteLine("this method is overriden and sealed in veena class");
        }
        public override void Vinay()
        {
            Console.WriteLine(" again method is overridden in veena class");
        }

    }
    public class Varun : Tejas
    {
        public Varun() : this("hello")
        {
            Console.WriteLine("this is not parameterized constructor in varun class");
        }
        public Varun(string name) 
        {
            Console.WriteLine("this is parameterized constructor in varun class");
        }
        public void Akash()
        {
            Console.WriteLine("overriden re-implementation is done in varun class");
        }
        public void kiran()
        {
            Console.WriteLine("this method is overriden and re-implemented in varun class");
        }
        public void Vinay()
        {
            Console.WriteLine(" again method is overridden and re-implemented");
        }

    }
    public class Yusuf : Varun
    {
        public Yusuf() : this("hey")
        {
            Console.WriteLine("this is yusuf non parameterized constructor in yusuf class");
        }
        public Yusuf(string name) : base()
        {
            Console.WriteLine("this is yusuf parameterized constructor in yusuf class");
        }

    }
    public class Sushma
    {
        public static void Main()
        {
           Tejas t=new Yusuf();
            t.kiran();
            t.Vinay();
            t.Akash();
            Console.WriteLine(Tejas.a);
            Console.WriteLine(Tejas.b);
            
            Tejas t1=new Veena();
            t1.kiran();
            t1.Vinay();

            
            
        }

        
    }
}
