using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
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
    


            //Qno.1: List countries in Europe Which Have population less than 10,000

            var europeanCountries = from member in countries
                                    where (member.Continents == Continents.Europe)&& (member.Population < 10000)
                                    select member;

            Console.WriteLine("European Countries with population < 10000:");
            foreach (var member in europeanCountries)
            {
                Console.WriteLine(member.Name);
            }

            //Q.2: List asian countries which are not ever invaded.
            
            
            var nonEnvaded = from member in countries
                                    where(member.Continents == Continents.Asia) && ( member.IndependenceDay==default)
                                    select member;
            Console.WriteLine("List asian countries which are not ever invaded:");
            foreach (var member in nonEnvaded)
            {
                Console.WriteLine(member.Name);
            }



        }
    }
}
