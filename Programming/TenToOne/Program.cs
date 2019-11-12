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

            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine("{0} Hello World!",counter);
                counter=counter+2;
            }
                   
        }
    }
   
}
