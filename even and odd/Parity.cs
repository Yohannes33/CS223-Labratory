using System;
namespace Parity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ans;
            do
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else Console.WriteLine("Odd");
                Console.WriteLine("Do you want to try again? ");
                ans = Char.Parse(Console.ReadLine());
            } while (ans == 'y');
        }
    }
}
