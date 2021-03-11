using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsHW
{
    class Program
    {
        public static int ReadInt()
        {
            bool isInt = false;
            int number;

            do
            {
                isInt = int.TryParse(Console.ReadLine(), out number);

            } while (isInt == false);

            return number;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ReadInt());

            Console.ReadKey();
        }
    }
}
