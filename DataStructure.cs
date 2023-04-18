using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myMark = new List<int>(); 
            myMark.Add(1);//0 will sr
            myMark.Add(2);
            myMark.Add(100);
            myMark.Remove(100);
            foreach (int k in myMark)
            {
                Console.WriteLine(k); 
            }
            IList<float> population = new List<float>();
            population.Add(200.23f);
            population.Add(30.3f);
            Console.WriteLine("==================================");
            foreach (float f in population)
            {
                Console.WriteLine(f);
            }
            ArrayList myarray = new ArrayList();
            myarray.Add(100);
            myarray.Add("Hello");
            Console.WriteLine();
            foreach (var g in myarray)
            {
                Console.WriteLine(g);
            }
            Stack s = new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(8);
            s.Push(7);
            Queue q = new Queue();
            q.Enqueue("Hi");
            q.Enqueue("Ok");
            q.Enqueue("1");
            Console.WriteLine(q.Dequeue());//hi
            Console.WriteLine(q.Dequeue());//ok
            Console.WriteLine(q.Dequeue());//1
            
            Console.WriteLine();
            try
            {
                Console.WriteLine(s.Pop());//7
                Console.WriteLine(s.Pop());//8
                Console.WriteLine(s.Pop());
                Console.WriteLine(s.Pop());
                Console.WriteLine(s.Pop());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.WriteLine("Press any key to colse the window");
            Console.ReadKey();
        }
    }
}
