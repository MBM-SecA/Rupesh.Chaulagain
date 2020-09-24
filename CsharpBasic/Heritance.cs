using System;
 
public interface IShapeWithSides
{
    public double GetDiagonal();
    
 
}
 
public abstract class Shape
{
 
    public abstract double GetArea();
    
 
    public abstract double GetCircumference();
    
    public virtual void Display()
    {
        Console.WriteLine("Displaying result");
 
    }


 
}
public class Square : Shape , IShapeWithSides
{
 
    public Square(double side)
    {
        Side = side;
    }
    public double Side {get; set;}
    public double breadth {get; set;}
    public override double GetArea() => Side * Side;
    public override double GetCircumference() => Side + breadth ;
 
    public override void Display()
    {
        Console.WriteLine($"displaying results for square with side {Side}:");
        Console.WriteLine($"Area: {this.GetArea()}");
        Console.WriteLine($"Diagonal : {this.GetDiagonal()}");
    }
    public double GetDiagonal() =>Math.Sqrt(2 *Side *Side);
 
    
 
}
public class Rectangle : Shape , IShapeWithSides
{
 
    public double length {get; set;}
    public double breadth {get; set;}
 
    public Rectangle(double Length, double Breadth)
    {
        Length = length;
        Breadth = breadth;
 
    }
    public override double GetArea() => length * breadth;
    public override double GetCircumference() => 2*(length + breadth );
 
    public double GetDiagonal() =>Math.Sqrt(length*length + breadth*breadth);
 
    
 
}
public class Circle : Shape
{
    public double Radius {get; set;}
    //public double breadth {get; set;}
    public override double GetArea() => Math.PI *Radius * Radius;
    public override double GetCircumference() => 2* Math.PI * Radius;
 
    
 
}
 class a {}
  class b : a {}
 
  class c : b , IA, IB {}
 
  interface IA {}
   interface IB {}

