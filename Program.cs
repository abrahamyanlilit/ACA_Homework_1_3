using System;

namespace ACA_Homework_1_3
{
    class Program
    {
        static void WriteInBox(string[] array)
        {
            int max = array[0].Length;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i].Length > max)
                {
                    max = array[i].Length;
                }
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
            WriteInBox(array);
        }
    }
}
