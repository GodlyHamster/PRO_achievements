using System;
using System.Threading;

namespace QA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome!");
            Console.WriteLine("Please answer a few questions before you start");
            Console.Clear();
            Console.WriteLine("What is your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you: ");
            string age = Console.ReadLine();
            Console.WriteLine("What is your favourite food: ");
            string favFood = Console.ReadLine();
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("That were all the questions, here are your answers\n");
            Console.WriteLine("Your name is: "+name);
            Console.WriteLine("You are "+age+" years old");
            Console.WriteLine("And your favourite food is: "+favFood+"\n");
            Thread.Sleep(1000);
            Console.WriteLine("Press any key to end the program...");
            Console.ReadKey();
        }
    }
}
