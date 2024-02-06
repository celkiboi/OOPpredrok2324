using System.Numerics;
using System.Runtime.CompilerServices;

namespace CompanyExercise;

public class Company(string name, decimal yearlyEarnings, decimal stockValue)
{
    string name = name;
    decimal yearlyEarnings = yearlyEarnings;
    decimal stockValue = stockValue;

    public string Name { get => name; set => name = value; }
    public decimal YearlyEarnings { get => yearlyEarnings; set => yearlyEarnings = value; }
    public decimal StockValue { get => stockValue; set => stockValue = value; }

    public static bool operator< (Company leftSide, Company rightSide)
    {
        return leftSide.StockValue < rightSide.StockValue;
    }

    public static bool operator> (Company leftSide, Company rightSide)
    {
        return !(leftSide < rightSide);
    }

    public string GetAcronym()
    {
        string[] words = Name
            .ToUpper()
            .Split(' ');
        string result = string.Empty;

        if (words.Length == 1)
            result = Name[..3];

        if (words.Length == 2) 
        {
            if (words[0].Length == 1)
                result = $"{words[0][0]}{words[1][0]}{words[1][1]}";
            else
                result = $"{words[0][0]}{words[0][1]}{words[1][0]}";
        }

        if (words.Length >= 3) 
        {
            result = $"{words[0][0]}{words[1][0]}{words[2][0]}";
        }

        return result;
    }
}
