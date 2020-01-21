using System;

namespace App2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int i;
            Console.WriteLine("Введите 10 чисел: ");
            for (i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i=0; i<array.Length;i++)
            {
                if(array[i]<=0)
                {
                    array[i] = 1;
                }
                Console.WriteLine($"X[{i}] = {array[i]}");
            }
        }
    }
}
