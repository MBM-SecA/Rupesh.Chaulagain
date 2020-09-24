using System.IO;
using System.Linq;
using System;
public class Program
{
    static void Main()
    {
      string countriestext = File.ReadAllText("Countries.txt");
      string[] countries=countriestext.Split("\r\n");

      var countrieswithinitial = countries.Select(x => x.StartsWith("N")).Select(x => x);
      foreach(var country in countrieswithinitial)
      {
          Console.WriteLine(country);
      }
    }
}