using System;

namespace TenToOne
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int counter = 10;
            while (counter > 0)
            {
                Console.WriteLine("{0} Hello World!",counter);
                counter--;
            } */

            /* int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine("{0} Hello World!",counter);
                counter=counter+2;
            } */

            int a;

            Console.Write("Number: ");
            a = Convert.ToInt32(Console.ReadLine());
            int t= 0;
            for (int i = 0; i < 11; i++)
            {
                if (i == 0)
                {
                   t = 1; 
                }
                else
                {
                    t *= a;
                    //a= t*t; prints 1
                    //t * t = a; error
                }
                
                Console.WriteLine("{0} ^ {1} = {2}",a, i, t);
            }
                   
        }
    }
   
}
