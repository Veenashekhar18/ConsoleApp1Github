using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.polymorphism
{
    public class Instagram

    {
            public virtual void Methodoverride()
            {
                Console.WriteLine("implementation on chats,emojis, story");
            }

    }
        public class Instagram2 : Instagram
        {

            public override void Methodoverride()
            {
                Console.WriteLine("implementation on chats,emojis,story and threads");
            }
        }
        
    
}
