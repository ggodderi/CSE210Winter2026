using System.ComponentModel.DataAnnotations;
using System.Numerics;

class Program
{
    public static void Main(string[] args)
    {
        Vector2D vector1 = new Vector2D(1,1);
        Vector2D vector2 = new Vector2D(10,12);
        Console.WriteLine(vector1.GetVectorDisplayString());
        Console.WriteLine((vector1 + vector2).GetVectorDisplayString());
        Console.WriteLine((vector1 - vector2).GetVectorDisplayString());

        if (vector1 != vector2)
        {
            vector1++;
            Console.WriteLine(vector1.GetVectorDisplayString());
        }

        if (vector2 > vector1)
        {
            vector1++;
            Console.WriteLine(vector1.GetVectorDisplayString());
        }

    }
}