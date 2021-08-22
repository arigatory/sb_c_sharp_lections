using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example_1638_Priority
{
    class Program
    {


        static void Main(string[] args)
        {
 
            ThreadWrapper[] threads = new ThreadWrapper[]
            {
                new ThreadWrapper() { Priority = ThreadPriority.Highest },
                new ThreadWrapper() { Priority = ThreadPriority.Lowest },
                new ThreadWrapper() { Priority = ThreadPriority.Normal }
            };

            foreach (var e in threads) e.Start();

            Console.WriteLine();
        }
    }
}