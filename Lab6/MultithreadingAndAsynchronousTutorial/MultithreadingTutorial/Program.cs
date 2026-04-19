var sw = System.Diagnostics.Stopwatch.StartNew();

var task1 = GetMessage1Async();
var task2 = GetMessage2Async();
var task3 = GetMessage3Async();

var results = await Task.WhenAll(task1, task2, task3);

foreach (var msg in results)
{
    Console.WriteLine(msg);
}

sw.Stop();
Console.WriteLine($"Total time: {sw.Elapsed.TotalSeconds:F1}s");

async Task<string> GetMessage1Async()
{
    await Task.Delay(1000);
    return "Message 1 (1s delay)";
}

async Task<string> GetMessage2Async()
{
    await Task.Delay(2000);
    return "Message 2 (2s delay)";
}

async Task<string> GetMessage3Async()
{
    await Task.Delay(3000);
    return "Message 3 (3s delay)";
}
