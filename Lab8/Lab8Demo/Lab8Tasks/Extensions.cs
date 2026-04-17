public static class Extensions
{
    public static bool IsPerfect(this int number)
    {
        if (number <= 1)
            return false;

        int sum = 1;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                sum += i;
                if (i != number / i)
                    sum += number / i;
            }
        }

        return sum == number;
    }

    public static bool IsMutuallyPrime(this int a, int b)
    {
        return Gcd(Math.Abs(a), Math.Abs(b)) == 1;
    }

    private static int Gcd(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public static bool IsWeekend(this DateTime date)
    {
        return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
    }

    public static bool IsPalindrome(this string text)
    {
        var cleaned = text.ToLower().Replace(" ", "");
        var reversed = new string(cleaned.Reverse().ToArray());
        return cleaned == reversed;
    }
}
