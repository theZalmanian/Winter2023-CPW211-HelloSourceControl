namespace HelloSourceControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get user's name
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            // Get number of requested greetings
            Console.Write("How many greetings would you like? ");
            int numGreetings = Convert.ToInt32(Console.ReadLine());

            // Display greeting for given # of times
            for (int currIndex = 0; currIndex < numGreetings; currIndex++)
            {
                Console.WriteLine($"{currIndex + 1}) Hello, {userName}!");
            }
        }
    }
}