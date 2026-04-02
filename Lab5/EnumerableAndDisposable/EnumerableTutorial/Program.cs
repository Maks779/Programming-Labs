using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

var bond = new PersonName("James", "Bond");
foreach (var name in bond)
{
    Console.WriteLine(name);
}

var rock = new PersonName("Dwayne", "Johnson", "Rock");
Console.WriteLine(rock.Skip(1).First());

using var analyzer = new TextAnalyzer("Hello, World! 123");
foreach (var c in analyzer)
    Console.Write(c);
Console.WriteLine();

public class PersonName : IEnumerable<string>
{
    public string FirstName { get; }
    public string? MiddleName { get; }
    public string LastName { get; }

    public PersonName(string firstName, string lastName, string? middleName = null)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerator<string> GetEnumerator()
    {
        yield return FirstName;
        if (MiddleName != null)
            yield return MiddleName;
        yield return LastName;
    }
}

public class TextAnalyzer : IEnumerable<char>, IDisposable
{
    private readonly string _text;
    private StringReader _reader;

    public TextAnalyzer(string text)
    {
        _text = text;
        _reader = new StringReader(text);
    }

    public IEnumerator<char> GetEnumerator()
    {
        _reader = new StringReader(_text);
        int ch;
        while ((ch = _reader.Read()) != -1)
        {
            char c = (char)ch;
            if (char.IsLetterOrDigit(c))
                yield return c;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public void Dispose()
    {
        _reader?.Dispose();
    }
}