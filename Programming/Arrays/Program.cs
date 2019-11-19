using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int size;
            System.Console.WriteLine("How many numbers in the array?");
            size = Convert.ToInt32(Console.ReadLine());
            
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                System.Console.WriteLine("Type your {0} numbers for this array:",size);
                array[i] = Convert.ToInt32(Console.ReadLine());
                //array[i] = i + 1;
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("a[{0}] = {1}", i , array[i]);     
            } */

            int size;
            System.Console.WriteLine("How many numbers in the array?");
            size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = i + i;
            }
            for (int i = 0; i < size; i++)
            {
                System.Console.WriteLine("a[{0}] = {1}", i, array[i]);
            }
            
        }
    }
}
