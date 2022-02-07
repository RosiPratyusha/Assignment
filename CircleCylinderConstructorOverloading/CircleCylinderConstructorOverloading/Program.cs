using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleCylinderConstructorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {

            Cylinder cylinders = new Cylinder(12.34, 10.0, "blue");

            Cylinder[] circles = {
                                    new Cylinder(12.34),
                                    new Cylinder(12.34, 10.0),
                                    new Cylinder(12.34, 10.0, "blue")

                                };
            Console.WriteLine(circles[0].getVolume());
            Console.WriteLine(circles[1].getVolume());
            Console.WriteLine(circles[2].getVolume());

            Console.ReadLine(); 

        }
    }
    public class Circle
    {
        public double radius;
        public Circle(double r)
        {
            radius = r;
        }
        public double getArea()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Cylinder
    {
        public Circle dt;
        public double height;
        public string color;

        public Cylinder(double r, double h, string c)
        {
            dt = new Circle(r);
            height = h;
            Console.WriteLine(c);
        }
        public Cylinder(double r, double h)
        {
            dt = new Circle(r);
            height = h;
        }
        public Cylinder(double r)
        {
            dt = new Circle(r);

        }
        public double getVolume()
        {
            return dt.getArea() * height;
            
        }
    }
}
