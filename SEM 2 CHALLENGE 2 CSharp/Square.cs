using System;
using System.Collections.Generic;
using System.Text;

namespace SEM_2_CHALLENGE_2_CSharp
{
    public class Square : Quadrilateral
    {
        public Square(string color, double sidelength1) : base(color, sidelength1, sidelength1, sidelength1, sidelength1)
        {

        }
        public override void Operation1()
        {
            throw new NotImplementedException();

        }
        public override double GetArea()
        {
            double area;
            area = SideLength1 * SideLength1;
            return area;
        }
        public override double GetPerimeter()
        {
            double perimeter;
            perimeter = SideLength1 * 4;
            return perimeter;
        }
    }
}
