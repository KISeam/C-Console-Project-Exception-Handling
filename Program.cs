class ExceptionHandling
{
    // Use TryParse()
    static double GetNumber(string input)
    {
        double result;
        if (double.TryParse(input, out result))
        {
            return result;
        }
        else
        {
            return 0;
        }
    }

    // Use TryCatch()
    static double GetNumber2(string input)
    {
        try
        {
            return Convert.ToDouble(input);
        }
        catch
        {
            return 0;
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Calculator Program 2 Numbers Using TryParse()");
        // Using TryParse()
        Console.Write("Enter Your First Number: ");
        double num1 = GetNumber(Console.ReadLine() ?? "0");
        Console.Write("Enter Your Second Number: ");
        double num2 = GetNumber(Console.ReadLine() ?? "0");

        Console.WriteLine($"Addition: {num1 + num2}");
        Console.WriteLine($"Subtraction: {num1 - num2}");
        Console.WriteLine($"Multiplication: {num1 * num2}");
        Console.WriteLine($"Division: {num1 / num2}");

        Console.WriteLine("\nCalculator Program 2 Numbers Using TryCatch()");
        // Using TryCatch()
        Console.Write("Enter Your First Number: ");
        double num3 = GetNumber2(Console.ReadLine() ?? "0");
        Console.Write("Enter Your Second Number: ");
        double num4 = GetNumber2(Console.ReadLine() ?? "0");

        Console.WriteLine($"Addition: {num3 + num4}");
        Console.WriteLine($"Subtraction: {num3 - num4}");
        Console.WriteLine($"Multiplication: {num3 * num4}");
        Console.WriteLine($"Division: {num3 / num4}");
    }
}
