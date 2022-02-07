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
                      
            Person[] people = {
                                new Person("Shyam", "Bangalore", "Karnataka", " fundamentals", 2010, 4500.0),
                                new Person("Anand", "Bangalore"," Karnataka", "Delhi Public school", 35000.0),
                                new Person("Umesh", "Bangalore", "Karnataka", "National Public school", 42000.0),
                                new Person("Suresh", "Hassan", "Karnataka", " fundamentals", 2012, 4750.0),
                                new Person("Kiran", "Vasco", "Goa", "Reactjs", 2017, 12500.0)
                                };
            Console.ReadLine();
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

