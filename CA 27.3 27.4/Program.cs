

public class MathOperations
{
    public static double CalculateAverage(int[] numbers)
    {
        double sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum / numbers.Length;
    }

    public static bool IsPrime(int number)
    {
        if (number / 1 == number && number / number == 1) return true;
        return false;
    }

    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public static bool IsOdd(int number)
    {
        return number % 2 != 0;
    }

    public static int CalculateFactorial(int number)
    {
        if (number == 0) return 1;
        return number * CalculateFactorial(number - 1);
    }

    public static string ConvertToBinary(int number)
    {
        return Convert.ToString(number, 2);
    }

    public static string ConvertToHex(int number)
    {
        return Convert.ToString(number, 16);
    }

    public static double CalculatePower(double x, double y)
    {
        return Math.Pow(x, y);
    }
}