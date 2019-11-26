using System;

namespace Arrays_matrix_auto1and0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tabA = new int[10,10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    //if (i % 2 == 0)
                    if(i == j)
                    {
                        tabA[i,j] = 1;
                    }                 
                    else
                    {
                        tabA[i,j] = 0;
                    }   
                    System.Console.Write("{0}", tabA[i,j]);
                }
                System.Console.WriteLine();
            }
        }
    }
}
