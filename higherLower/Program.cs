using System;
using System.IO;
using System.Threading;

namespace higherLower
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            Random rnd = new Random();
            int number = 0;
            int answer = 0;
            int lives = 5;
            int wins = 0;
            int lowest = 1;
            int highest = 100;
            int guessesLeft = 10;
            bool lost = false;

            //begin
            Console.Clear();
            Console.WriteLine("Welcome to a game called: Higher or Lower!\n");
            Console.WriteLine("The rules are simple: ");
            Console.WriteLine("1. You guess a number between two numbers");
            Console.WriteLine("2. The machine says if the number is higher or lower");
            Console.WriteLine("3. You repeat step 1");
            Console.WriteLine("4. Good luck and have fun\n");
            Thread.Sleep(1000);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            //program
            number = rnd.Next(1,100);
            while (!lost)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                for (int i = 0; i<lives;i++)
                {
                    Console.SetCursorPosition(i * 7, 0);
                    Console.Write("/\\/\\ \n");
                    Console.SetCursorPosition(i * 7, 1);
                    Console.Write("\\  / \n");
                    Console.SetCursorPosition(i * 7, 2);
                    Console.Write(" \\/  \n");
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nWins: "+wins);
                Console.WriteLine(guessesLeft+ " guesses left\n");
                Console.WriteLine("Choose a number between "+lowest+" and "+highest+":");
                string guess = Console.ReadLine();
                bool succes = Int32.TryParse(guess, out answer);
                if (succes)
                {
                    // checks if the number is higher, lower or THE number;
                    if (number == answer)
                    {
                        Console.WriteLine("You guessed the number!");
                        wins++;
                        lowest = 1;
                        highest = 100 + wins * 50;
                        number = rnd.Next(1, highest);
                        guessesLeft = 11;
                    }
                    else
                    {
                        if (number > answer)
                        {
                            Console.WriteLine("The number is higher");
                            if (answer > lowest)
                            {
                                lowest = answer;
                            }
                        }
                        if (number < answer)
                        {
                            Console.WriteLine("The number is lower");
                            if (answer < highest)
                            {
                                highest = answer;
                            }
                        }
                    }
                    if (guessesLeft <= 0 && number != answer)
                    {
                        Console.WriteLine("You lost a life, better luck next time!");
                        lowest = 1;
                        highest = 100 + wins*50;
                        number = rnd.Next(1, highest);
                        guessesLeft = 11;
                        lives -= 1;
                    }
                    if (lives == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("You lost...");
                        lost = true;
                    }
                    guessesLeft -= 1;
                    Thread.Sleep(500);
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
                else {
                    Console.WriteLine("please enter a number");
                    Thread.Sleep(500);
                }
            }

            //when u win
            Console.Clear();
            Console.WriteLine("Your score was: " + wins);
            Console.WriteLine("Type your name: ");
            string name = Console.ReadLine();
            File.WriteAllText(@"highscores.txt", name);
            Thread.Sleep(500);
        }
    }
}
