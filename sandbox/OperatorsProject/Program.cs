using System.Data;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        string? myName = null;
        int x = myName?.Length ?? 0;

        Console.WriteLine(x);

        myName ??= "Bob";
        Console.WriteLine(myName);

        myName ??= "Betty";
        Console.WriteLine(myName);

    }
}