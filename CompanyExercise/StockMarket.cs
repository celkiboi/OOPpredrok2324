using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable IDE0290 // Use primary constructor
#pragma warning disable IDE0044 // Add readonly modifier
#pragma warning disable IDE0052 // Remove unread private members

namespace CompanyExercise;

public class StockMarket
{

    private string name;
    private List<Company> listedCompanies;

    public StockMarket(string name, List<Company> listedCompanies)

    {
        this.name = name;
        this.listedCompanies = listedCompanies;
    }

    public string GetName()
    {
        return this.name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetAdBanner()
    {
        return $"Work with {name} for maximum profits";
    }
}

#pragma warning restore IDE0044 // Add readonly modifier
#pragma warning restore IDE0290 // Use primary constructor
#pragma warning restore IDE0052 // Remove unread private members
