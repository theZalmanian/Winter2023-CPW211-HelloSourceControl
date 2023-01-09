namespace HelloSourceControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("How many greetings would you like? ");
            int numGreetings = Convert.ToInt32(Console.ReadLine());

            for (int currIndex = 0; currIndex < numGreetings; currIndex++)
            {
                Console.WriteLine($"{currIndex + 1}) Hello, {name}!");
            }
        }
    }
}