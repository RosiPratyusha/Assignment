using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonStaffStudent
{
    class Program
    {
        static void Main(string[] args)
        {

            person[] people = {
                                new Student("Shyam", "Bangalore, Karnataka", " fundamentals", 2010, 4500.0),
                                new Staff("Anand", "Bangalore, Karnataka", "Delhi Public school", 35000.0),
                                new Staff("Umesh", "Bangalore, Karnataka", "National Public school", 42000.0),
                                new Student("Suresh", "Hassan, Karnataka", " fundamentals", 2012, 4750.0),
                                new Student("Kiran", "Vasco, Goa", "Reactjs", 2017, 12500.0)
                              };
            foreach (var item in people)
            {
                Console.WriteLine("Name: " + item.Name + " and Address: " + item.Address);
                
            }

            Console.ReadLine();
        }
        public interface person
        {
            string Name { get; set; }

            string Address { get; set; }

        }
        public class Student : person
        {
            public Student(string name, string address, string course, int year, double fee)
            {
                Name = name;
                Address = address;
                Course = course;
                Year = year;
                Fee = fee;
            }

            public string Name { get; set; }
            public string Address { get; set; }

            public string Course { get; set; }

            public int Year { get; set; }

            public double Fee { get; set; }
        }

        public class Staff : person
        {
            public Staff(string name, string address, string school, double salary)
            {
                Name = name;
                Address = address;
                Salary = salary;
                School = school;
            }
            public string Name { get; set; }
            public string Address { get; set; }

            public string School { get; set; }

            public double Salary { get; set; }
        }

    }

    public class Student
    {
        
        public Student(string name, string city, string state, string school, int year, double fees)
        {
        }
    }
    public class Staff
    {
       
        public Staff(string name, string city, string state, string school, double salary)
        {
        }
    }
    public class Person
    {
                
        public Person(string v1, string v2, string v3,string v4, double v5)
        {
            Console.WriteLine("Staff Details:" + "Name: " + v1 + ", City:" + v2 + ", State: " + v3 + ", School: "+v4+", Salary: " + v5);

        }
        public Person(string name, string city, string state, string school, int year, double fees)
        {
            Console.WriteLine("Student Details:" + "Name: " + name + ", City: " + city + ", State: " + state + ", Year: " + year + ", fees:" + fees);
        }


    }
}

