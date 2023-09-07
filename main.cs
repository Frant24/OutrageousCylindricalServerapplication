using System;

class Program
{
    private const double CM_PER_INCH = 2.54;

    static void Main()
    {
        Console.WriteLine("Enter the measurement in inches:");
        double inches = double.Parse(Console.ReadLine());
        
        double centimeters = ConvertInchesToCentimeters(inches);
        Console.WriteLine($"{inches} inches is {centimeters} centimeters.");
    }

    static double ConvertInchesToCentimeters(double inches)
    {
        return inches * CM_PER_INCH;
    }
}
