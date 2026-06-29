using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Shape
    {
        
    }

    public abstract class Shapes
    {
        public double Height;
        public double Width;
        public double Radius;
        public const float PI = 3.14f;
        public abstract double getArea();
    }
    public class Rectangle : Shapes
    {
        public Rectangle(double Height, double Width)
        {
            this.Height = Height;
            this.Width = Width;
        }

        public override double getArea()
        {
            return Width * Height;
        }
    }
    public class Circle : Shapes
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public override double getArea()
        {
            return PI * Radius * Radius;
        }
    }
    public class Triangle : Shapes
    {
        public Triangle(double Height, double Width)
        {
            this.Height = Height;
            this.Width = Width;
        }

        public override double getArea()
        {
            return (Width * Height) / 2;
        }
    }
    public class Cone : Shapes
    {
        public Cone(double Radius, double Height)
        {
            this.Radius = Radius;
            this.Height = Height;
        }

        public override double getArea()
        {
            return PI * Radius * (Radius + Math.Sqrt(Height * Height + Radius * Radius));   
        }
    }
}
