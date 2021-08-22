using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example_1612
{
    class Program
    {

        private static void Sound()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"+ ");
                Thread.Sleep(200);
            }
        }

        static void Main(string[] args)
        {

            // Thread - объектно-ориентированное представление потока ОС
            // с его помощью него можно создавать потоки, управлять ими, получиить информацию о них 

            // Monitor - простейший примитив синхронизаций

            // Interlocked - работа с атомарными операциями

            Console.WriteLine("Начало... ");

            ThreadStart ts = new ThreadStart(Sound);
            Thread therad = new Thread(ts);
            therad.Start();


            for (int i = 0; i < 100; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"- ");
                Thread.Sleep(20);
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nОкончание... ");

        }

    }
}
