using CompanyExercise;
using IoTExercise;
using CircleExercise;

#pragma warning disable CA1859 // Use concrete types when possible for improved performance

namespace Predrok2324;

internal class Program
{
    static void Main()
    {
        Exercise1();
        Exercise2();
        Exercise3();
        Exercise7();
        Exercise10();
    }

    static void Exercise1()
    {
        Company span = new("SPAN", 105_100_100m, 50.60m);
        Company ericsson = new("Ericsson Nikola Tesla", 300_000_000m, 61.66m);
        Company largest = span > ericsson ? span : ericsson;
        Console.WriteLine($"{largest.Name}, revenue: {largest.YearlyEarnings}, stock: {largest.StockValue}");
    }

    static void Exercise2()
    {
        Company[] companies =
        [
            new("Prvo plinarsko društvo", 0, 0),
            new("SPAN", 0, 0),
            new("Q agency", 0, 0),
            new("In trade", 0, 0),
        ];

        foreach ( Company company in companies ) 
        {
            Console.WriteLine(company.GetAcronym());
        }
    }

    static void Exercise3()
    {
        Dictionary<int, Company> yearlyReports = new()
        {
            {2012, new("infinum", 84_000_105, 35.44m) },
            {2014, new("infinum", 91_000_105, 44.11m) },
            {2016, new("infinum", 63_000_105, 22.27m) },
        };
        DrasticYears drasticYears = StockAnalyst.FindDrasticYears(yearlyReports);
        Console.WriteLine($"Best: {drasticYears.BestYear}, worst: {drasticYears.WorstYear}.");
    }

    static void Exercise7()
    {
        SensorArray sensei = new(2, 1);
        sensei[0, 0] = new LightSensor(1, 50, 2);
        sensei[1, 0] = new LightSensor(1, 0, 2); //Promjenite u (1, 10, 2) ako ne želite exception

        try
        {
            Console.WriteLine($"Time left: {sensei.CalculateTimeLeftInSeconds()}");
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex);
        }
    }

    static void Exercise10() 
    {
        Console.WriteLine("enter how many random circles do you want?");
        string? input = Console.ReadLine();

        bool success = int.TryParse(input, out int numberOfCircles);

        if (!success)
        {
            Console.WriteLine("Not a valid input");
            return;
        }

        List<Circle> generatedCircles = [];
        Random random = new();
        for(int i = 0; i < numberOfCircles; i++) 
        {
            generatedCircles.Add(random.NextCircle(10));
        }
        Circle pickedCircle = generatedCircles[0];
        ICirclePicker picker = new AreaPicker();
        int maxIndex = numberOfCircles - 1;
        List<Circle> remainingCircles = generatedCircles[1..maxIndex];
        var mostSimilar = picker.PickMostSimilar(pickedCircle, remainingCircles);
        Console.WriteLine($"Original circle: {pickedCircle.Radius * 2 * Math.PI} Most similar circle: {mostSimilar?.Radius * 2 * Math.PI}");
    }
}

#pragma warning restore CA1859 // Use concrete types when possible for improved performance
