namespace Nucleos.Domain.ValueObjects;

public class DoubleValidator
{
    private string input = "20220,00";
    public static bool IsValid(string input)
    {
        DoubleNumber doubleNumber;
        return double.TryParse(input.ToString(), out _);
    }
}