using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        public static void Shuffle(int[] array)
        {
            Random random = new Random();

            for (int i = array.Length-1; i >= 0; i--)
            {
                int index = random.Next(0, i);

                int temp = array[i];
                array[i] = array[index];
                array[index] = temp;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] array = new int[10];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10, 100);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            Shuffle(array);

            Console.ReadKey();
        }
    }
}
