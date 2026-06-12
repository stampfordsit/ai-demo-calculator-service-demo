namespace CalculatorServiceDemo.Services;

public class AdvancedCalculatorService
{
    public double Power(double baseValue, double exponent)
    {
        return Math.Pow(baseValue, exponent);
    }

    public double SquareRoot(double value)
    {
        if (value < 0)
            throw new ArgumentException("Value cannot be negative.", nameof(value));

        return Math.Sqrt(value);
    }

    public long Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentException("Value must be non-negative.", nameof(n));

        if (n == 0)
            return 1;

        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }
}
