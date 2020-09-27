using System;
public class Country
{
    public string Name {get ; set;}

    public string Continent {get ; set;}
    public double Area {get ; set;}
    public long Population {get; set;}

    public DateTime IndependenceDay {get; set; }
    public Country(string n, string c, double a,long p , DateTime i=default)
    {
        Name = n;
        Continent= c;Area = a;
        Population=p;
        IndependenceDay=i;
    }
}