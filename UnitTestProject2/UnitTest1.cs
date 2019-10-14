using System;
using SEM_2_CHALLENGE_2_CSharp;
using NUnit.Framework;

namespace UnitTestProject2
{
    [TestFixture]
    public class Tests
    {


        Square Sq1 { get; set; }
        Square Sq2 { get; set; }
        Square Sq3 { get; set; }
        Rectangle Rec1 { get; set; }
        Rectangle Rec2 { get; set; }
        Rectangle Rec3 { get; set; }

        Circle Cir1 { get; set; }
        Circle Cir2 { get; set; }
        Circle Cir3 { get; set; }

        Equilateral Equ1 { get; set; }
        Equilateral Equ2 { get; set; }
        Equilateral Equ3 { get; set; }
        Rightangle RA1 { get; set; }
        Rightangle RA2 { get; set; }
        Rightangle RA3 { get; set; }
        [SetUp]

        public void Init()
        {
            Sq1 = new Square("Blue", 5);
            Sq2 = new Square("Blue", 15);
            Sq3 = new Square("Blue", 7);

            Rec1 = new Rectangle("b", 5, 10);
            Rec2 = new Rectangle("b", 4, 6);
            Rec3 = new Rectangle("b", 9, 7);

            Cir1 = new Circle("b", 5);
            Cir2 = new Circle("b", 15);
            Cir3 = new Circle("b", 7);

            RA1 = new Rightangle(5, 10, "B");
            RA2 = new Rightangle(4, 6, "B");
            RA3 = new Rightangle(9, 7, "B");

            Equ1 = new Equilateral(5, "b");
            Equ2 = new Equilateral(15, "b");
            Equ3 = new Equilateral(7, "b");
        }



        [Test]
        public void SquareTests()
        {
             double area = 25;
            double perimeter = 20;

            Assert.AreEqual(area, Sq1.GetArea());
            Assert.AreEqual(perimeter, Sq1.GetPerimeter());

            area = 225;
            perimeter = 60;

            Assert.AreEqual(area, Sq2.GetArea());
            Assert.AreEqual(perimeter, Sq2.GetPerimeter());

            area = 49;
            perimeter = 28;

            Assert.AreEqual(area, Sq3.GetArea());
            Assert.AreEqual(perimeter, Sq3.GetPerimeter());
        }
        [Test]
        public void RectangleTests()
        {
            double area = 50;
            double perimeter = 30;

            Assert.AreEqual(area, Rec1.GetArea());
            Assert.AreEqual(perimeter, Rec1.GetPerimeter());

            area = 24;
            perimeter = 20;

            Assert.AreEqual(area, Rec2.GetArea());
            Assert.AreEqual(perimeter, Rec2.GetPerimeter());

            area = 63;
            perimeter = 32;

            Assert.AreEqual(area, Rec3.GetArea());
            Assert.AreEqual(perimeter, Rec3.GetPerimeter());
        }
        [Test]
        public void EqualateralTests()
        {
            double area = 10.83;
            double perimeter = 15;

            Assert.AreEqual(area, Equ1.GetArea());
            Assert.AreEqual(perimeter, Equ1.GetPerimeter());

            area = 97.43;
            perimeter = 45;

            Assert.AreEqual(area, Equ2.GetArea());
            Assert.AreEqual(perimeter, Equ2.GetPerimeter());

            area = 21.22;
            perimeter = 21;

            Assert.AreEqual(area, Equ3.GetArea());
            Assert.AreEqual(perimeter, Equ3.GetPerimeter());
        }

        [Test]
        public void RightAngleTest()
        {
            double area = 25;
            double perimeter = 26.18;

            Assert.AreEqual(area, RA1.GetArea());
            Assert.AreEqual(perimeter, RA1.GetPerimeter());

            area = 12;
            perimeter = 17.21;

            Assert.AreEqual(area, RA2.GetArea());
            Assert.AreEqual(perimeter, RA2.GetPerimeter());

            area = 31.5;
            perimeter = 27.4;

            Assert.AreEqual(area, RA3.GetArea());
            Assert.AreEqual(perimeter, RA3.GetPerimeter());
        }


        [Test]
        public void CircleTests()
        {
            double area = 10.83;
            double perimeter = 15;

            Assert.AreEqual(area, Cir1.GetArea());
            Assert.AreEqual(perimeter, Cir1.GetPerimeter());

            area = 97.43;
            perimeter = 45;

            Assert.AreEqual(area, Cir2.GetArea());
            Assert.AreEqual(perimeter, Cir2.GetPerimeter());

            area = 21.22;
            perimeter = 21;

            Assert.AreEqual(area, Cir3.GetArea());
            Assert.AreEqual(perimeter, Cir3.GetPerimeter());
        }

    }
}
