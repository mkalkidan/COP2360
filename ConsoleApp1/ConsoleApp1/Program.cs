using System;
using System.Linq.Expressions;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the first number: ");
            string input1 = Console.ReadLine();
            int number1 = Convert.ToInt32(input1);
            Console.WriteLine("Enter the second number: ");
            string input2 = Console.ReadLine();
            int number2 = Convert.ToInt32(input2);
            int result = number1 / number2;
            Console.WriteLine("The result is: " + result);

        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Division by zero is not allowed.");
            Console.WriteLine($"The errror is: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Check if your input is valid integer");
            Console.WriteLine($"The errror is: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error occured.");
            Console.WriteLine($"The errror is: {ex.Message}");
        }

    }
}