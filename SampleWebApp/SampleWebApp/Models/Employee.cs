using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApp.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public double EmpSalary { get; set; }

        public override string ToString()
        {
            string content = $"<h1>Details of Mr.{EmpName}</h1><hr/><p>The ID: {EmpId}</p><p>The Name: {EmpName}</p><p>The Address: {EmpAddress}</p><p>The Salary: {EmpSalary:C}</p>";
            return content;
        }
    }
    
}