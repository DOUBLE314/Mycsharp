using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShape
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] obg = new Shape[]
                {
                    new Triangle(5, 6, 8, 8, "Triangle"),
                    new Square (9, "Square"),
                    new Rectangle(5, 9, "Rectangle")
                };

            foreach (var shape in obg)
                Console.WriteLine(shape.GetInfo());

            Console.ReadKey();
        }
    }

  }
public abstract class Shape
{
    protected double width, length;
    protected string name;

    protected Shape(double width, string name)
        : this(width, 0.0, name)
    {
    }

    protected Shape(double width, double length, string name)
    {
        this.width = width;
        this.length = length;
        this.name = name;
    }

    public abstract double Area();
    public abstract string GetInfo();
    public abstract double Perimeter();

}
public class Triangle : Shape
{
    protected double side3, hight;

    public Triangle(double width, double length, double side3, double hight, string name)
        : base(width, length, name)
    {
        this.side3 = side3;
        this.hight = hight;

    }

    public override double Area()
    {
        return width * hight / 2;
    }

    public override string GetInfo()
    {
        return string.Format("Это треугольник {0} со сторонами: {1},{2},{3}\nArea : {3}\nPerimeter : {4}",
                             name, width, hight, side3, Area(), Perimeter());
    }

    public override double Perimeter()
    {
        return width + hight + side3;
    }
}
public class Square : Shape
{
    public Square(double width, string name)
        : base(width, name)
    {
    }

    public override double Area()
    {
        return width * width;
    }

    public override string GetInfo()
    {
        return string.Format("Это квадрат {0} со стороной: {1},\nArea : {2}\nPerimeter : {3}",
                             name, width, Area(), Perimeter());
    }

    public override double Perimeter()
    {
        return width * 4;
    }

}
public class Rectangle : Shape
{
    public Rectangle(double width, double length, string name)
        : base(width, length, name)
    {
    }

    public override double Area()
    {
        return width * length;
    }

    public override string GetInfo()
    {
        return string.Format("Это прямоугольник {0} со стороной: {1},\nArea : {2}\nPerimeter : {3}",
                             name, width, Area(), Perimeter());
    }

    public override double Perimeter()
    {
        return 2 * (width + length);
    }
}