using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _723rol
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for(int i=0;i<t;i++)
            {
                Queue<string> q = new Queue<string>(Console.ReadLine().Split(' '));
                q.Dequeue();
                var item = q.Dequeue();
                q.Enqueue(item);

                foreach(var x in q)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine();


            }
        }
    }
}
