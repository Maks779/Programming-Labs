Console.WriteLine("=== Task 3: CollectionAnalyzer FindRange ===");

var numbers = new List<int> { 3, 7, 1, 9, 4, 2, 8 };
var analyzer = new CollectionAnalyzer(numbers);
var range = analyzer.FindRange();

Console.WriteLine($"Min: {range.Min}, Max: {range.Max}, Range: {range.Range}");

Console.WriteLine("\n=== Task 4: Deconstruction and null tuple ===");

var (min, max, r) = analyzer;
Console.WriteLine($"Deconstructed - Min: {min}, Max: {max}, Range: {r}");

var emptyAnalyzer = new CollectionAnalyzer(new List<int>());
var emptyResult = emptyAnalyzer.FindRange();
Console.WriteLine($"Empty collection - Min: {emptyResult.Min}, Max: {emptyResult.Max}, Range: {emptyResult.Range}");

var nullAnalyzer = new CollectionAnalyzer(null);
var (nullMin, nullMax, nullRange) = nullAnalyzer;
Console.WriteLine($"Null collection deconstructed - Min: {nullMin}, Max: {nullMax}, Range: {nullRange}");

Console.WriteLine("\n=== Task 5: FindRange with position filter ===");

var rangeFiltered = analyzer.FindRange((3, 7));
Console.WriteLine($"Range [3,7] - Min: {rangeFiltered.Min}, Max: {rangeFiltered.Max}, Range: {rangeFiltered.Range}");

var rangeNoMatch = analyzer.FindRange((50, 100));
Console.WriteLine($"Range [50,100] - Min: {rangeNoMatch.Min}, Max: {rangeNoMatch.Max}, Range: {rangeNoMatch.Range}");

try
{
    analyzer.FindRange((10, 2));
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Invalid range exception: {ex.Message}");
}

Console.WriteLine("\n=== Task 6: IsPerfect extension method ===");
Console.WriteLine($"6 is perfect: {6.IsPerfect()}");
Console.WriteLine($"28 is perfect: {28.IsPerfect()}");
Console.WriteLine($"12 is perfect: {12.IsPerfect()}");
Console.WriteLine($"496 is perfect: {496.IsPerfect()}");

Console.WriteLine("\n=== Task 7: IsMutuallyPrime extension method ===");
Console.WriteLine($"8 and 15 are mutually prime: {8.IsMutuallyPrime(15)}");
Console.WriteLine($"12 and 18 are mutually prime: {12.IsMutuallyPrime(18)}");
Console.WriteLine($"7 and 13 are mutually prime: {7.IsMutuallyPrime(13)}");

Console.WriteLine("\n=== Task 8: IsWeekend extension method ===");
var saturday = new DateTime(2026, 4, 18);
var monday = new DateTime(2026, 4, 20);
Console.WriteLine($"{saturday:yyyy-MM-dd} (Saturday) is weekend: {saturday.IsWeekend()}");
Console.WriteLine($"{monday:yyyy-MM-dd} (Monday) is weekend: {monday.IsWeekend()}");

Console.WriteLine("\n=== Task 9: IsPalindrome extension method ===");
Console.WriteLine($"\"racecar\" is palindrome: {"racecar".IsPalindrome()}");
Console.WriteLine($"\"hello\" is palindrome: {"hello".IsPalindrome()}");
Console.WriteLine($"\"A man a plan a canal Panama\" is palindrome: {"A man a plan a canal Panama".IsPalindrome()}");
