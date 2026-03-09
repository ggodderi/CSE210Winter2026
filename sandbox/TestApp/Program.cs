class Program
{
    public static double InputRadius()
    {
        double radius = 0;
        bool done = false;

        while (!done)
        {
            try
            {
                Console.Write("Please input the radius (double): ");
                radius = double.Parse(Console.ReadLine());
                if (radius <= 0)
                {
                    throw new Exception("Number must be positive.");
                }
                done = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please input a valid number . . . ");
            }
        }

        return radius;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Hey");
        Console.WriteLine(InputRadius());

        TestClass testObject = new TestClass();
        TestClass testObject2 = new TestClass(234.234);
        TestClass testObject3 = new TestClass(234.234f);

        Console.WriteLine(testObject3.GetData());
        Console.WriteLine(testObject2.GetData());
        Console.WriteLine(testObject.GetData());
        
    }
}