using System;

namespace Shapes {

  class Triangle
  {
    private int Side1;
    private int Side2;
    private int Side3;

    public Triangle(int side1, int side2, int side3)
    {
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
    }

    public string TriangleType ()
    {    

        if (Side1 > Side2 + Side3 || Side2 > Side1 + Side3 || Side3 > Side1 + Side2){
            return "Invalid";
        }
        else if (Side1 == Side2 && Side2 == Side3) {
            return "Equilateral";
        }
        else if (Side1 == Side2 || Side2 == Side3 || Side1 == Side3) {
            return "Isosceles";
        }
        else if (Side1 != Side2 && Side2 != Side3 && Side1 != Side3) {
            return "Scalene";
        }
       return "";
    }


  }

}