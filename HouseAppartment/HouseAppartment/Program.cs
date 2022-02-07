using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseAppartment
{
    class Program
    {
        static void Main(string[] args)
        {
            Apartment apartment = new Apartment();
            Person person = new Person("Rosi");
            apartment.door = new House.Door("Brown");
            person.house = apartment;
            person.ShowData();
            Console.ReadLine();
        }
    }
    public class House
    {
        public int Area { get; set; }
        public Door door;

        public House(int area = 200)
        {
            Area = area;
        }

        public void ShowData()
        {
            Console.WriteLine($"Area of my house is: {Area} m2");
        }

        public Door GetDoor()
        {
            return door;
        }

        public class Door
        {
            public string Color { get; set; }

            public Door(string color = "white")
            {
                Color = color;
            }

            public void ShowData()
            {
                Console.WriteLine($"Color of the door is: {Color}");
            }
        }
    }

    public class Apartment : House
    {
        public Apartment(int area = 50) : base(area)
        {
        }
    }

    public class Person
    {
        private string name;
        public House house { get; set; }

        public Person(string name)
        {
            this.name = name;
        }

        public void ShowData()
        {
            Console.WriteLine($"A person whose name is {name}");
            Console.WriteLine("Details of house:");
            house.ShowData();
            Console.WriteLine("Details of door:");
            house.GetDoor().ShowData();
        }

    }
}

