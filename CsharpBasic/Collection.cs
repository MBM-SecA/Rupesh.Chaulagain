
using System.Collections.Generic;
using System;

namespace LearnCollections
{
    public class Collections
    {
        void LearnLists()
        {
            List<byte>ages = new List<byte>();//You can initialize here{20,22};
            ages.Add(21);
            ages.Add(17);
            ages.Add(27);
            ages.Add(60);

            List<Country>countries = new List<Country>();
            Country country1 = new Country();//or countries.Add(new Country()); 

        }
       public  void LearnDictionary()
        {
            Dictionary<string , string> countryCapitals = new Dictionary<string, string>();
           // {
           //     ["Nepal"] = "Kathmandu",
           //     ["India"] = "New Delhi"

          //  };
        
            countryCapitals.Add("Nepal","Kathmandu");
            countryCapitals.Add("Bhutan","Thimphu");
            countryCapitals.Add("China","Beijing");

            foreach(var country in countryCapitals)
            {
                Console.WriteLine($"The capital city of {country.Key} is {country.Value}");
            }
        }

    }
    public class Country
    {
        public string Name { get; set;}

    }
}