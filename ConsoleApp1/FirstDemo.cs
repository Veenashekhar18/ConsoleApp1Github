using ConsoleApp1.Inheritence;
using ConsoleApp1.polymorphism;
using ConsoleApp1.Programs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FirstDemo
    {
        public static void Main(String[] args)
        {
            //Console.WriteLine("hello world");
            //Pattern.pattern();
            //Addition.Add();
            //Datatypes d= new Datatypes();
            //d.Data();
            //Bubblesort b= new Bubblesort();
            //b.SortAsc();
            //IFelsepgm i= new IFelsepgm();
            //i.Condition();
            //MaxnMinofdatatype.MaxandMinvalue();
            //Mainclass m = new Mainclass();
            //m.Inherit();
            // Inter inter = new Inter();
            //inter.Demo1();
            //inter.Demo();
            CountVowels.count();
            Find1n2n3largest.Findlargest();
            Merge2Arrays merge2Arrays = new Merge2Arrays();
            merge2Arrays.Merge2();
            RemoveduplicateinIntegerArray.Removeduplicate();
            ReverseString.Reverse();
            Instagram2 i=new Instagram2();
            i.Methodoverride();
            Compiletime c=new Compiletime();
            c.main("hi");
            c.main("hello", 13);
            c.main(1.2f, 52);




        }
    }
}
