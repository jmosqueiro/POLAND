using System;

namespace Arrays_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tabA = new int[2,3];
            int[,] tabB = new int[2,3];
            int[,] tabC = new int[2,3];
            Console.WriteLine("tabA: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                Console.Write("tabA [{0},{1}]: ",i,j);
                tabA[i,j] = int.Parse(Console.ReadLine());   
                }
            }
            Console.Clear();
            System.Console.WriteLine("tabB: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    System.Console.Write("tabB[{0},{1}]: ",i,j);
                    tabB[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            System.Console.WriteLine("tabC = tabA + tabB");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tabC[i,j] = tabA[i,j] + tabB[i,j];
                    System.Console.Write("{0}\t",tabC[i,j]);
                }
                Console.WriteLine();
            }
            //Console.ReadKey();
        }
    }
}
