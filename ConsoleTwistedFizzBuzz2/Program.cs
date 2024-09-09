
namespace ConsoleTwistedFizzBuzz2
{
    class Program
    {
        static void Main()
        {
            TwistedFizzBuzzLibrary.TwistedFizzBuzzLibrary fizzBuzz = new TwistedFizzBuzzLibrary.TwistedFizzBuzzLibrary();

            for (int i = -20; i <= 127; i++)
            {
                string output = fizzBuzz.GetFizzBuzzForNumber(i, 5, 9, "Fizz", "Buzz");
                if (i % 27 == 0)
                {
                    output += "Bar";
                }
                Console.WriteLine(output);
            }
        }
    }
}