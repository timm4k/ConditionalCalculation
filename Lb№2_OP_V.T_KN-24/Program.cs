class Program
{
    static void Main()
    {
        Console.WriteLine("Enter value for x:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter value for y:");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter value for z:");
        double z = Convert.ToDouble(Console.ReadLine());

        double result;

        if (z != 3 && y > 10)
        {
            result = (3 * x + 9 * y) / (2 + 3 * z);
        }
        else if (y < 8 || x < 5)
        {
            result = 7 * y + 5 * x - z;
        }
        else
        {
            result = Math.Pow(z, 2) - 3;
        }

        Console.WriteLine($"Result: {result:F3}");
    }
}
