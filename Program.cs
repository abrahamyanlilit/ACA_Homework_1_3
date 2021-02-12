using System;

namespace ACA_Homework_1_3
{
    class Program
    {
        static void f(string[] array)
        {
            int[] array1 = new int[1000];

            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < array[i].Length; j++)
                    count++;
                array1[i] = count;
            }

            int max = array1[0];
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > max)
                    max = array1[i];
            }

            int asterisks = max + 4;
            for (int i = 0; i < asterisks; i++)
                Console.Write("*");
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("* " + array[i]);
                for (int j = 0; j < asterisks - 2 - array[i].Length - 1; j++)
                    Console.Write(" ");
                Console.WriteLine("*");
            }

            for (int i = 0; i < asterisks; i++)
                Console.Write("*");
        }
        static void Main(string[] args)
        {
            string[] array = { "Hello", "my", "name", "is", "Lilit" };
            f(array);
        }
    }
}
