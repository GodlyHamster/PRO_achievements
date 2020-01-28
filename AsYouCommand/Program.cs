using System;

namespace AsYouCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 0;
            int maxNumber = 0;

            Console.Clear();
            Console.WriteLine("Hoe groot moet de lijst zijn?");
            Int32.TryParse(Console.ReadLine(),out arrayLength);
            Console.WriteLine("Tot welk getal mogen de willekeurige getallen gaan?");
            Int32.TryParse(Console.ReadLine(),out maxNumber);
            Array.ForEach(MakeArray(arrayLength, maxNumber), Console.WriteLine);
        }

        static int[] MakeArray(int length, int maxNum)
        {
            Random rnd = new Random();

            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = rnd.Next(0, maxNum);
            }
            return result;
        }
    }
}
