//Tuples and Deconstruction

var (gcd, lcm) = GcdLcm(48, 36);

Console.WriteLine(gcd);
Console.WriteLine(lcm);

var s1 = new Student("James", "Bond", 45);

var (name, age) = s1;
Console.WriteLine(name);
Console.WriteLine(age);

(int Gcd, int Lcm) GcdLcm(int a, int b)
{
    var originalA = a;
    var originalB = b;

    while (a != b)
    {
        if (a > b)
        {
            a -= b;
        }
        else
        {
            b -= a;
        }
    }

    return (a, originalA * originalB / a);
}

public class Student
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public Student(string name, string lastName, int age)
    {
        Name = name;
        LastName = lastName;
        Age = age;
    }

    //Deconstruction
    public void Deconstruct(out string fullName, out int age)
    {
        fullName = $"{Name} {LastName}";
        age = Age;
    }
}

//public class Result
//{
//    public int Gcd { get; set; }
//    public int Lcm { get; set; }
//}