using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Синхронизация потоков

namespace Example_1631
{
    class Program
    {

        static void Method()
        {
            var th = Thread.CurrentThread;

            th.Name = "MethodThread";

            Console.WriteLine($"Поток: {th.Name}, ID: {th.GetHashCode()}");

            for (int i = 0; i < 100; i++)
            {
                Console.Write("+ ");
                Thread.Sleep(100);
            }

            Console.WriteLine($"\nПоток: {th.Name}, ID: {th.GetHashCode()}. Конец работы");
        }

        static void Main(string[] args)
        {
            var mainThread = Thread.CurrentThread;

            mainThread.Name = "CurrentThread";

            Console.WriteLine($"Поток: {mainThread.Name}, ID: {mainThread.GetHashCode()}");


            Thread secondThead = new Thread(Method);
            secondThead.Start();
            //secondThead.Join();

            for (int i = 0; i < 100; i++)
            {
                Console.Write("- ");
                Thread.Sleep(100);
            }

            Console.WriteLine($"\nПоток: {mainThread.Name}, ID: {mainThread.GetHashCode()}. Конец работы");


        }
    }
}
