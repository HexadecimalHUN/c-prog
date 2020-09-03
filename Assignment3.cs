using System;

namespace ConsoleApplication1
{
    public class Shape
    {
        public string ToString;
        public double Area;
        public double Parimeter;


    }

    public class Rectangle : Shape
    {
        double Side1 = 21;
        double Side2 = 21;
    }

    public class Circle : Shape
    {
        double Radius = 21;

    }

    public class Location
    {
        private double X = 21;
        private double Y = 21;
    }

    class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }
}
