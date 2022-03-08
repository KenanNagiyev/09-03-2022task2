using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 83, 96, 56, 2, 9, 8, 15, 62 };
            Console.WriteLine(Min(array));
        }
        static int Min(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
    }
}
