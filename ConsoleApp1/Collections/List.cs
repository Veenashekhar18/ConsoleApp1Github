using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Collections
{
    public class List
    {
        public void listadd()
        {
            // adding elements in list
            List<string> l = new List<string>();
            l.Add("hello");
            l.Add("hii");
            l.Add("hey");
            l.Add("anime");
            foreach (string s in l)
            {
                Console.WriteLine(s);
            }

        }
        public class Hashset
        {
            public void Hashsetadd()
            {
                HashSet<string> hs = new HashSet<String>();
                hs.Add("safari");
                hs.Add("car");
                hs.Add(".net");
                hs.Add("java");
                hs.Add("amazon");
                foreach(string s in hs)
                {
                    Console.WriteLine(s);   
                }
            }
        }
      
        public class Sortedsetcollection
        {
            public void Sortedsetadd()
            {
                SortedSet<String> l = new SortedSet<String>();
                l.Add("amazon");
                l.Add("facebook");
                l.Add("twitter");
                l.Add("instagram");
                foreach(String s in l)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public class Stackcollection
        {
            public void Stackadd()
            {
                Stack<String> l = new Stack<String>();
                l.Push("V");
                l.Push("e");
                l.Push("e");
                l.Push("n");
                l.Push("a");
                foreach(String s in l)
                {
                    Console.WriteLine(s);
                }

            }
        }
        public class Queuecollection
        {
            public void Queueadd()
            {
                Queue<String> q = new Queue<String>();
                q.Enqueue("A");
                q.Enqueue("B");
                q.Enqueue("C");
                q.Enqueue("D");
                q.Enqueue("E");
                foreach(String s in q)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine(q.Dequeue());
                Console.WriteLine(q.Dequeue());
                Console.WriteLine(q.Dequeue());
                Console.WriteLine(q.Dequeue());
                Console.WriteLine(q.Dequeue());
            }
        }
        public class Linkedlistcollection
        {
            public void Linkedadd()
            {
                LinkedList<string> l = new LinkedList<string>();
                l.AddFirst("atomic");
                l.AddFirst("work");
                l.AddFirst("knowledge");
                l.AddFirst("gain");
                l.AddLast("habits");
                l.AddLast("silence");
                foreach(String s in l)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("=======");
                LinkedListNode<String> n = l.Find("atomic");
                l.AddAfter(n, "HEY");
                l.AddBefore(n, "Hello");
                foreach(String s in l)
                {
                    Console.WriteLine(s);
                }

            }
           
      
        }
        public class Dictionarycollection
        {
            public void Dictionaryadd()
            {
                Dictionary<int, string> l = new Dictionary<int, string>();
                l.Add(1, "addition");
                l.Add(2, "multiplication");
                l.Add(3, "division");
                l.Add(4, "sub");
                l.Add(5, "modulus");
               
                foreach(KeyValuePair<int, string> kv in l)
                {
                    Console.WriteLine(kv.Key+" "+kv.Value);
                }
            }
        }
        public class Sorteddictionarycollection
        {
            public void Sortedadd()
            {
                SortedDictionary<int,string> s=new SortedDictionary<int,string>();
                s.Add(1, "booleanval");
                s.Add(2, "alphabets");
                s.Add(3, "languages");
                s.Add(4, "multilple");
                foreach(KeyValuePair<int, string> kv in s)
                {
                    Console.WriteLine(kv.Key + " " + kv.Value);
                }
            }
        }
        public class SortedListcollection
        {
            public void Sorted()
            {
                SortedList<String,int> s=new SortedList<String,int>();
                s.Add("vollyball", 1);
                s.Add("hockey", 2);
                s.Add("cricket",3);
                s.Add("football", 4);
               foreach(KeyValuePair<string,int > kv in s)
                {
                    Console.WriteLine(kv.Key + " " + kv.Value);
                }
            }
        }
        public class Execution
        {
            public static void Main()
            {
                List list = new List();
                list.listadd();
                Hashset h=new Hashset();
                h.Hashsetadd();
                Sortedsetcollection s=new Sortedsetcollection();
                s.Sortedsetadd();
                Stackcollection s1 = new Stackcollection();
                s1.Stackadd();
                Queuecollection q1 = new Queuecollection();
                q1.Queueadd();
                Linkedlistcollection l1= new Linkedlistcollection();    
                l1.Linkedadd();
                Dictionarycollection d1= new Dictionarycollection();
                d1.Dictionaryadd();
                Sorteddictionarycollection sd= new Sorteddictionarycollection();
                sd.Sortedadd();
                SortedListcollection sl=new SortedListcollection();
                sl.Sorted();


            }
        }
    }
}
