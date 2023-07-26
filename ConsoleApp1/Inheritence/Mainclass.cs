using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp1.Inheritence
{
    internal class Mainclass : Baseclass
    {
        public void Inherit()
        {
            Mainclass b =new Mainclass();
            b.Addition();
            b.Multipliaction(); 
        }
    }
}
