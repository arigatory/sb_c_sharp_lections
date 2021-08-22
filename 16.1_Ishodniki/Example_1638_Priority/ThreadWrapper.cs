using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example_1638_Priority
{
    class ThreadWrapper
    {
        static bool endCalculations;

        static ThreadWrapper()
        {
            endCalculations = false;
        }

        private Thread t;
        private int args;

        public ThreadWrapper()
        {
            t = new Thread(Calc);
            args = 1_000_000;
        }

        public ThreadPriority Priority { set { t.Priority = value; } }


        private void Calc()
        {
            while (!endCalculations && this.args != 0)
            {
                args--;
            }

            endCalculations = true;
            Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId} завершён. Приоритет {t.Priority}. Args = {args}");
        }

        public void Start()
        {
            t.Start();
        }
    }
}
