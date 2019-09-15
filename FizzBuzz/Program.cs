using System;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vai começar o mundo do fizz buzz!!!");

            FizzBuzzExecuter executer = new FizzBuzzExecuter();

            for (int i = 0; i <= 100; i++)
            {
                string result = executer.Execute(i);
                Console.WriteLine(result);
            }
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
