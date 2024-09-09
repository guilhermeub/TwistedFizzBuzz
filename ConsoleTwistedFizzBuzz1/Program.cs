
namespace ConsoleTwistedFizzBuzz1
{
    class Program
    {
        static void Main()
        {
            TwistedFizzBuzzLibrary.TwistedFizzBuzzLibrary fizzBuzz = new TwistedFizzBuzzLibrary.TwistedFizzBuzzLibrary();
            string result = fizzBuzz.GetFizzBuzzForRange(1, 100);
            Console.WriteLine(result);
        }
    }
}