using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int read = 0;
            int nrand = rand.Next(1,10);
            Console.WriteLine("guess the Number from 1 - 10");
            Console.WriteLine(nrand);

            read = Convert.ToInt32(Console.ReadLine());
            

            if(read != nrand)
            {
                Console.WriteLine("Wrong number");
            }
            
            else Console.WriteLine("--- HIT ---");


            
        }
    }
}
