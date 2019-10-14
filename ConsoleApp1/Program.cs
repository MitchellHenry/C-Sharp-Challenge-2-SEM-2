using System;
using System.Collections.Generic;
using SEM_2_CHALLENGE_2_CSharp;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            List<Square> Squares = new List<Square>();
            List<Rectangle> Rectangles = new List<Rectangle>();
            List<Equilateral> Equalaterals = new List<Equilateral>();
            List<Rightangle> RightAngles = new List<Rightangle>();
            List<Circle> Circles = new List<Circle>();
            while (count != 1)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Do you want to make a shape? Yes/No");
                    string response = Console.ReadLine();
                    if (response == "No" || response == "")
                    {
                        Console.ReadKey(true);
                    }
                    else
                    {
                        Console.WriteLine("What shape do you want to make?");
                        Console.WriteLine(" - Square");
                        Console.WriteLine(" - Rectangle");
                        Console.WriteLine(" - Right Angle Trianagle");
                        Console.WriteLine(" - Equalaterial Triangle");
                        Console.WriteLine(" - Circle");
                        response = (Console.ReadLine());
                        if (response == "Square")
                        {
                            
                            Console.Clear();
                            Console.WriteLine("whats the side length?");
                            double sidelength;                           
                            sidelength = double.Parse(Console.ReadLine());
                            if((sidelength % 1) > 0)
                            {
                                throw new NoDecimals("No decimals allowed!");
                            }
                           
                            Console.WriteLine("Whats the color of the shape?");
                            string color = Console.ReadLine();
                            Square New = new Square(color, sidelength);
                            Squares.Add(New);

                        }
                        if (response == "Rectangle")
                        {
                            Console.Clear();
                            Console.WriteLine("whats the side length 1?");
                            double sidelength1;
                            sidelength1 = double.Parse(Console.ReadLine());
                            if ((sidelength1 % 1) > 0)
                            {
                                throw new NoDecimals("No decimals allowed!");
                            }
                            Console.WriteLine("whats the side length 2?");
                            double sidelength2;
                            sidelength2 = double.Parse(Console.ReadLine());
                            if ((sidelength2 % 1) > 0)
                            {
                                throw new NoDecimals("No decimals allowed!");
                            }
                            Console.WriteLine("Whats the color of the shape?");
                            string color = Console.ReadLine();
                            Rectangle New = new Rectangle(color, sidelength1, sidelength2);
                            Rectangles.Add(New);
                        }
                        if (response == "Right Angle Trianagle")
                        {
                            Console.Clear();
                            Console.WriteLine("whats the side length 1?");
                            double sidelength1;
                            sidelength1 = double.Parse(Console.ReadLine());
                            if ((sidelength1 % 1) > 0)
                            {
                                throw new NoDecimals("No decimals allowed!");
                            }
                            Console.WriteLine("whats the side length 2?");
                            double sidelength2;
                            sidelength2 = double.Parse(Console.ReadLine());
                            if ((sidelength2 % 1) > 0)
                            {
                                throw new NoDecimals("No decimals allowed!");
                            }
                            Console.WriteLine("Whats the color of the shape?");
                            string color = Console.ReadLine();
                            Rightangle New = new Rightangle(sidelength1,sidelength2,color);
                            RightAngles.Add(New);
                        }
                        if (response == "Equalaterial Triangle")
                        {
                            Console.Clear();
                            Console.WriteLine("whats the side length 1?");
                            double sidelength1;
                            sidelength1 = double.Parse(Console.ReadLine());
                            if ((sidelength1 % 1) > 0)
                            {
                                throw new NoDecimals("No decimals allowed!");
                            }
                            Console.WriteLine("Whats the color of the shape?");
                            string color = Console.ReadLine();
                            Equilateral New = new Equilateral(sidelength1,color);
                            Equalaterals.Add(New);
                        }
                        if (response == "Circle")
                        {
                            Console.Clear();
                            Console.WriteLine("whats the radius of the circle?");
                            double radius;
                            radius = double.Parse(Console.ReadLine());
                            if ((radius % 1) > 0)
                            {
                                throw new NoDecimals("No decimals allowed!");
                            }
                            Console.WriteLine("Whats the color of the shape?");
                            string color = Console.ReadLine();
                            Circle New = new Circle(color,radius);
                            Circles.Add(New);
                        }
                        else
                        {
                            Console.WriteLine("Unkown Shape");
                        }
                    }
                }
                catch(Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);                 
                }
                Console.ReadKey(true);
            }
        }
    }
}
