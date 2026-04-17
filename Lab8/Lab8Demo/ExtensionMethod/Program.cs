var someShittyString = "hello from the OTHer sIDe"; //-> "Hello from the other side"

Console.WriteLine(someShittyString);

var fixedString = someShittyString.ToSentence();

Console.WriteLine(fixedString);

Console.WriteLine(7.IsEven());
Console.WriteLine(7.IsOdd());
Console.WriteLine(2.IsPrime());

List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
Console.WriteLine(numbers.First());
Console.WriteLine(numbers.Second());

public static class Extensions
{
    public static T Second<T>(this IEnumerable<T> input) => input.Skip(1).First();

    public static string ToSentence(this string input)
    {
        return input[0].ToString().ToUpper() + input.Substring(1).ToLower();
    }

    public static bool IsEven(this int number) => number % 2 == 0;

    public static bool IsOdd(this int number) => !number.IsEven();

    public static bool IsPrime(this int number)
    {
        if (number == 1 )
            return false;
        if (number == 2)
            return true;

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}

//this idea would be cool if it worked :-(
// public class BetterString : string
// {
//     public string ToSentence()
//     {
//         return ""; //something
//     }
// }
