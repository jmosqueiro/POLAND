using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            NewGame:
            //Random rand = new Random(); //random each time you type a number
            Random rand = new Random(DateTime.Now.Millisecond); //same random 
            int winNum = Convert.ToInt32(rand.Next(1,11));
            int read;
            int numberOfAttempts = 3;
            int counter = 0;

            Start:

            //int nrand = rand.Next(1,10);
            Console.WriteLine("Guess the mumber from 1 to 10 ");

            Console.WriteLine(winNum);
            read = Convert.ToInt32(Console.ReadLine());
            counter++;
            if (read == winNum)
            {
              Console.WriteLine("\n HIT! ");  
            }
            else 
            {
                    if (read < winNum)
                {
                    Console.WriteLine("Too Low");
                }
                else 
                    Console.WriteLine("Too High");
                Console.WriteLine("Try again...");
                if (counter < numberOfAttempts)
                {
                    goto Start;
                }
                else
                Console.WriteLine("#Game Over, Winning number was: "+winNum);
            }
            Console.WriteLine("Do you want to play again? y - yes:");
            string decision = Console.ReadLine();
            if (decision == "y" || decision == "Y")
            {
                goto NewGame;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("thank you!");

            }
        }
    }
}
