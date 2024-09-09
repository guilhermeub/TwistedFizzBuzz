namespace TwistedFizzBuzzTests;

public class TwistedFizzBuzzTests
{
    [Fact]
    public void TestFizzBuzzRange()
    {
        TwistedFizzBuzzLibrary.TwistedFizzBuzzLibrary fizzBuzz = new TwistedFizzBuzzLibrary.TwistedFizzBuzzLibrary();
        var result = fizzBuzz.GetFizzBuzzForRange(1, 15);

        string expected = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz";
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestFizzBuzzSet()
    {
        TwistedFizzBuzzLibrary.TwistedFizzBuzzLibrary fizzBuzz = new TwistedFizzBuzzLibrary.TwistedFizzBuzzLibrary();
        var result = fizzBuzz.GetFizzBuzzForSet(new List<int> { -5, 6, 300, 12, 15 });

        string expected = "Buzz\nFizz\nFizzBuzz\nFizz\nFizzBuzz";
        Assert.Equal(expected, result);
    }

    [Fact]
    public async Task TestAPI()
    {
        TwistedFizzBuzzLibrary.TwistedFizzBuzzLibrary fizzBuzz = new TwistedFizzBuzzLibrary.TwistedFizzBuzzLibrary();
        var tokens = await fizzBuzz.GetTokensFromAPI();
        Assert.NotNull(tokens.Item1);
        Assert.NotNull(tokens.Item2);
    }
}
