using System;

namespace GC_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;
            
            while (continueProgram)
            {
                int num = PromptForInteger("Please enter an integer to generate a powers table");
                CreatePowersTable(num);
                continueProgram = ContinueProgram("Would you like to continue with a new number?");
            }
        }

        public static bool ContinueProgram(string message)  //prompts user if they'd like to continue and verifies proper entry
        {
            Console.Write($"{message} (y/n) ");
            string response = Console.ReadLine().ToLower();

            while (response != "y" && response != "n" )
            {
                Console.WriteLine("Your entry was invalid.  Please respond (y/n) ");
                response = Console.ReadLine().ToLower();
            }

            if (response == "y")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Thanks for using this program.  Goodbye!");
                return false;
            }
        }

        public static void CreatePowersTable (int n)  //creates a powers table based on the integer passed
        {
            Console.WriteLine("Number\t\tSquared\t\tCubed");
            Console.WriteLine("=======\t\t=======\t\t=======");

            int square = n;
            int cube = n;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i}\t\t{i*i}\t\t{i*i*i}");
            }

        }

        public static int PromptForInteger (string message)  //prompts user for an integer and verifies the entry
        {
            int number = 0;
            Console.Write(message + ": ");
            string input = Console.ReadLine();

            while (!int.TryParse(input, out number))
            {
                Console.Write("Invalid entry.  Please enter a valid integer. ");
                input = Console.ReadLine();
            }

            return number;
        }

    }
}
