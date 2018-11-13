using System;
using System.Collections.Generic;

namespace Shapes {

  public class Program
  {
    public static void Main()
    {
     
    Console.WriteLine("Please enter side1 of your triangle: ");
    int side1 = Int32.Parse(Console.ReadLine());
    
    Console.WriteLine("Please enter side2 of your triangle: ");
    int side2 = Int32.Parse(Console.ReadLine());
    
    Console.WriteLine("Please enter side3 of your triangle: ");
    int side3 = Int32.Parse(Console.ReadLine());

    Triangle triangle = new Triangle(side1, side2, side3);

    Console.WriteLine("Your triangle is type " + triangle.TriangleType() );

    Console.ReadLine();


    }
  }

}