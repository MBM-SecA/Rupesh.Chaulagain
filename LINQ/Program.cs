using System;
using System.Linq;


class Program
{
    static void Main()
    {
        //Linq -Language Integrated Query
        //LINQ to objects
        int[] numbers = { 23, 34, 55, 45, 87, 666 };
        // Fetch numbers greater than 50.
        // using method syntax - Lambda expression.
        var numGreaterThan50 = numbers.Where(x => x > 50);

        // Using SQL Query syntax - query expression
        var numgreaterthanfifty = from num in numbers
                                  where num > 50
                                  select num;

        string[] names = {"Rupesh", "Sting", "Jeff", "kurt", "Jack"};
        var choosed = from name in names
                      where name.StartsWith("R") && (name.Length > 3)
                      select name;

        var result3 = names.Where(y => y.Length > 3 && y.StartsWith("R"));
        Console.WriteLine(result3);

        List<Country> countries = Country.GetCountries();
            var asianCountries = from member in countries
                                 where member.Continents == Continents.Asia
                                 select member;
            foreach (var member in asianCountries)
            {
                Console.WriteLine(member.Name); 
            }
    }
}

