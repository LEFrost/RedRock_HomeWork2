using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(p =>
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.Write('$');
                    Thread.Sleep(2000);
                }


            });
            t.Start();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine('@');
                Thread.Sleep(1000);
            }
            Console.ReadKey();
        }
    }
}
