using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_ClassAndObject.Abstraction
{
    abstract public class Shape
    {
        public abstract void CalculateArea();
        public abstract void Display();
    }

    public class Circle:Shape 
    {
        double area,radius=10;
     public override void CalculateArea()
        {
            area = 3.14 * radius * radius;
           
        } 

    public override void Display()
        {
            Console.WriteLine(area + " is area of circle");
        }
    }
    public class RectangleShape : Shape
    {
        private double area, width=40, length=20;
        public override void CalculateArea()
        {
            area = width * length;
        }

        public override void Display()
        {
            Console.Write(area + " is area of Rectangle");
        }
    }

}
