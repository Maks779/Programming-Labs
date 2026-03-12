Console.WriteLine("Hello, World");

List<int> TransformNumbers(List<int> numbers, Func<int, int> transform)
{
    List<int> result = new List<int>();
    foreach (int number in numbers)
    {
        result.Add(transform(number));
    }
    return result;
}

List<int> FilterNumbers(List<int> numbers, Func<int, bool> predicate)
{
    List<int> result = new List<int>();
    foreach (int number in numbers)
    {
        if (predicate(number))
        {
            result.Add(number);
        }
    }
    return result;
}

int AggregateNumbers(List<int> numbers, int initialValue, Func<int, int, int> aggregator)
{
    int result = initialValue;
    foreach (int number in numbers)
    {
        result = aggregator(result, number);
    }
    return result;
}

void Repeat(int times, Action action)
{
    for (int i = 0; i < times; i++)
    {
        action();
    }
}

Func<int, int> CreateMultiplier(int factor)
{
    return x => x * factor;
}

List<int> list = new List<int> { 1, 2, 3, 4, 5, 10 };

Console.WriteLine(string.Join(", ", TransformNumbers(list, x => x * 2)));

Console.WriteLine(string.Join(", ", FilterNumbers(list, x => x % 2 == 0)));

Console.WriteLine(AggregateNumbers(list, 0, (acc, x) => acc + x));

Repeat(2, () => Console.WriteLine("Action!"));

var multiplyBy5 = CreateMultiplier(5);
Console.WriteLine(multiplyBy5(10));

public class Integrator
{
    public double Integrate()
    {
        var start = 0.0;
        var end = 1.0;
        var step = 0.1;

        var sum = 0.0;

        for (var x = start; x < end; x += step)
        {
            var y = x * x;
            sum += y * step;
        }

        return sum;
    }
}
