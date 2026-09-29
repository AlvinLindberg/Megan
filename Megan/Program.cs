namespace Megan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 101);
            Console.Write("Gissa ett tal mellan 1 och 100: ");
            int guess = Convert.ToInt32(Console.ReadLine());
            while (guess != number)
            {
                if (guess < number)
                {
                    Console.WriteLine("För lågt! Försök igen.");
                }
                else
                {
                    Console.WriteLine("För högt! Försök igen.");
                }
                Console.Write("Gissa igen: ");
                guess = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Grattis! Du gissade rätt.");


        }
    }
}
