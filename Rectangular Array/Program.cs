using System;

namespace Rectangular_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = {{11,12,13,14},
                            {31,32,33,34},
                            {51,52,53,54}

            };

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
