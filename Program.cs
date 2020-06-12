using System;

namespace ConsoleApp1
{
    class Program
    {
        private static readonly string Er = "error";
        static void Main(string[] args)
        {

            var line1 = System.Console.ReadLine().Trim();
            if (int.TryParse(line1, out int Input) && (0 < Input && Input < 101))
            {
                for (int i = 1; i <= Input; i++)
                {
                    switch (i)
                    {
                        case int n when n % 5 == 0 && n % 3 == 0:
                            Console.WriteLine("Fizz Buzz");
                            break;
                        case int n when n % 5 == 0:
                            Console.WriteLine("Buzz");
                            break;
                        case int n when n % 3 == 0:
                            Console.WriteLine("Fizz");
                            break;
                        default:
                            Console.WriteLine(i);
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine(Er);
            }
        }
    } 
}
