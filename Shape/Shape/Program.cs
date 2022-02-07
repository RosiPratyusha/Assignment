using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape { BackColor = "Yellow", FillStatus = true };
            Console.WriteLine(shape);

            shape = new Rectangle { Length = 200, Width = 300 };
            Console.WriteLine(shape);

            shape = new Square { side = 20 };
            Console.WriteLine(shape);

            shape = new Circle { radius = 5 };
            Console.WriteLine(shape);
        }
    }
    class Shape
    {
        public bool FillStatus { get; set; }
        public string BackColor { get; set; }
        public override string ToString()
        {
            string oldValue = "Shape ";
            string value = "";
            if (FillStatus == true) value = "filled"; else value = "Not Filled";
            oldValue += $"| A Shape  with color {BackColor} and {value}";
            return oldValue;
        }
    }
    class Rectangle : Shape
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public override string ToString()
        {
            string baseValue = base.ToString();
            string value = $"Rectange|A Rectange with width = {Width} and Length = {Length} and is a subclass of {this.GetType().BaseType.Name}";
            return value;
        }
    }
    class Square : Shape
    {
        public int side { get; set; }
        public override string ToString()
        {
                string baseValue = base.ToString();
                string value = $"Square|A Square with side = {side} and is a subclass of {this.GetType().BaseType.Name}";
                return value;
        }
    }
    class Circle : Shape
    {
        public int radius { get; set; }
        public override string ToString()
        {
            string baseValue = base.ToString();
            string value = $"Circle|A Circle with Radius = {radius} and is a subclass of {this.GetType().BaseType.Name}";
            return value;
        }
    }
}
