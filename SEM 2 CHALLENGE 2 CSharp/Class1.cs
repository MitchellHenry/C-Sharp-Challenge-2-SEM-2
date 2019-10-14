using System;

namespace SEM_2_CHALLENGE_2_CSharp
{
    public abstract class Shape
    {
        public string Color;

        public Shape(string color)
        {
            this.Color = color;
        }
        public abstract void Operation1();
    }
    public abstract class Quadrilateral : Shape, IShapeCalc
    {
        public double SideLength1;
        public double SideLength2;
        public double SideLength3;
        public double Sidelength4;

        public Quadrilateral(string color, double sidelength1, double sidelength2, double sidelength3, double sidelength4) : base(color)
        {
            this.SideLength1 = sidelength1;
            this.SideLength2 = sidelength2;
            this.SideLength3 = sidelength3;
            this.Sidelength4 = sidelength4;
        }
        public abstract double GetArea();
        public abstract double GetPerimeter();      
       
    }

    public class Rectangle : Quadrilateral
    {
        public Rectangle(string color, double sidelength1, double sidelength2) : base(color, sidelength1, sidelength2, sidelength1, sidelength2)
        {

        }
        public override void Operation1()
        {
            throw new NotImplementedException();
        }
        public override double GetArea()
        {
            double area;
            area = SideLength1 * SideLength2;
            return area;
        }
        public override double GetPerimeter()
        {
            double perimeter;
            perimeter = SideLength1 + SideLength2 + SideLength1 + SideLength2;
            return perimeter;
        }
    }

    public abstract class Triangle : Shape
    {
      public double SideLength1;
      public double Sidelength2;
      public double Sidelength3;

        public Triangle(string color,double sidelength1,double sidelength2,double sidelength3) : base(color)
        {
            SideLength1 = sidelength1;
            Sidelength2 = sidelength2;
            Sidelength3 = sidelength3;
        }
       
    }

    public class Equilateral : Triangle,IShapeCalc
    {
        public Equilateral(double sidelength1, string color) : base(color, sidelength1, sidelength1, sidelength1)
        {
        }
        public override void Operation1()
        {
            throw new NotImplementedException();
        }
        public  double GetArea()
        {
            double area = Math.Sqrt(3) / 4 * Math.Pow(SideLength1, 2);
            area = Math.Round(area,2);
           return area;           
        }
        public double GetPerimeter()
        {
            double perimeter = SideLength1 * 3;
            perimeter = Math.Round(perimeter,2);
            return perimeter;
        }
    }


    public class Rightangle : Triangle, IShapeCalc
    {
        public Rightangle(double sidelength1,double sidelength2, string color) : base(color, sidelength1, sidelength2, 0)
        {
            SetHypotenuse();
        }
        public override void Operation1()
        {
            throw new NotImplementedException();
        }
        
        public double GetArea()
        {
            double area = 0.5 * SideLength1 * Sidelength2;
            area = Math.Round(area,2);
            return area;
        }
        public void SetHypotenuse()
        {
           Sidelength3 =  Math.Sqrt(Math.Pow(SideLength1, 2) + Math.Pow(Sidelength2, 2));
        }
       
        public double GetPerimeter()
        {
            double perimeter = SideLength1 + Sidelength2 + Sidelength3;
            perimeter = Math.Round(perimeter,2);
            return perimeter;

        }
    }

    public class Circle : Shape,IShapeCalc
    {
        public double PI { get; } = 3.14159265358979;
        public double Radius;

        public Circle(string color, double radius) : base(color)
        {         
            Radius = radius;
        }
        public override void Operation1()
        {
            throw new NotImplementedException();
        }
        public double GetArea()
        {
            double area = PI * Math.Pow(Radius, 2);
            area = Math.Round(area,2);
            return area;
        }
        public double GetPerimeter()
        {
            double perimeter = (2 * PI) * Radius;
            perimeter = Math.Round(perimeter,2);
            return perimeter;
        }
    }

















        interface IShapeCalc
    {
        double GetArea();
        double GetPerimeter();
    }
}


public class NoDecimals: Exception
{
    public NoDecimals(string message) : base(message)
    {

    }
}
