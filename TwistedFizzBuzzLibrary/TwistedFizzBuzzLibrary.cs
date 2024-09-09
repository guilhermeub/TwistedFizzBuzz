
using Newtonsoft.Json;

namespace TwistedFizzBuzzLibrary;

public class TwistedFizzBuzzLibrary
{
    public string GetFizzBuzzForRange(int start, int end, int div1 = 3, int div2 = 5, string token1 = "Fizz", string token2 = "Buzz")
    {
        List<string> result = new List<string>();

        for (int i = start; i <= end; i++)
        {
            result.Add(GetFizzBuzzForNumber(i, div1, div2, token1, token2));
        }

        return string.Join(Environment.NewLine, result);
    }

    public string GetFizzBuzzForSet(List<int> numberList, int div1 = 3, int div2 = 5, string token1 = "Fizz", string token2 = "Buzz")
    {
        List<string> result = new List<string>();

        foreach (var num in numberList)
        {
            result.Add(GetFizzBuzzForNumber(num, div1, div2, token1, token2));
        }

        return string.Join(Environment.NewLine, result);
    }

    public string GetFizzBuzzForNumber(int num, int div1, int div2, string token1, string token2)
    {
        bool isByDiv1 = num % div1 == 0;
        bool isByDiv2 = num % div2 == 0;

        if (isByDiv1 && isByDiv2) return token1 + token2;

        if (isByDiv1) return token1;

        if (isByDiv2) return token2;


        return num.ToString();
    }

    public async Task<(string, string)> GetTokensFromAPI()
    {
        using (HttpClient client = new HttpClient())
        {
            string url = "https://pie-healthy-swift.glitch.me/";
            var response = await client.GetStringAsync(url);
            var tokenList = JsonConvert.DeserializeObject<List<string>>(response);
            return (tokenList[0], tokenList[1]);
        }
    }
}

