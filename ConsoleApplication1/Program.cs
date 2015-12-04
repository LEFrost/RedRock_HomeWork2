using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            func2();

        }
        public static async Task<string> func()
        {
            return await Task.Run(() =>
            {
                for (int i = 1; i <= 10; i++)
                {
                    Thread.Sleep(2000);
                    Console.Write('$');
                }
                return "";

            });
        }
        public static string func2()
        {
            func();
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine('@');
            }

            return "";
        }
    }
}
