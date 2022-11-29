using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Models
{
    class Employee
    {
        public static int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee(string EmployeeName,string EmployeeSurName,int EmployeeAge,double EmployeeSalary)
        {
           
            Name = EmployeeName;
            SurName = EmployeeSurName;
            Age = EmployeeAge;
            Salary = EmployeeSalary;
        }



    }
}
