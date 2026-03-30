using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal mySimpleGaol = new SimpleGoal();

        mySimpleGaol.CreateGoal();
        Console.WriteLine(mySimpleGaol.GetConsoleString());
    }
}