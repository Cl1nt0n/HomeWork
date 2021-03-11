using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        public static void HealthBar(int percent)
        {
            char[] bar = new char[10];

            for (int i = 0; i < bar.Length; i++)
            {
                if (i*10 <= percent - 10)
                {
                    bar[i] = '#';
                }
                else
                {
                    bar[i] = '_';
                }
            }

            for (int i = 0; i < bar.Length; i++)
            {
                Console.Write(bar[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            int percent = int.Parse(Console.ReadLine());

            HealthBar(percent);

            Console.ReadKey();
        }
    }
}
