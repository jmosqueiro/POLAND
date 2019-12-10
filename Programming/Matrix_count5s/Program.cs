using System;

namespace Matrix_count5s
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[2,5];
            int ct = 0;
            
           
            Console.WriteLine("A: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                Console.Write("A [{0},{1}]: ",i,j);
                A[i,j] = int.Parse(Console.ReadLine());   
                //if (A[i,j] == 5 ) //check if i,j == 5 after de reads
                        ct+=A[i,j]; //Number Sum
                        //ct++;
                }
            }

            
            System.Console.WriteLine("Matrix A:");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                        System.Console.Write("{0}\t",A[i,j]);
                }
                
                Console.WriteLine();
            }
            System.Console.WriteLine("Counter: {0}", ct);
            //Console.ReadKey();
        }
    }
}
