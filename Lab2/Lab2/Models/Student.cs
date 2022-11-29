using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Models
{
    class Student
    {
        public static int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public double AvgMark { get; set; }

      

        public Student(string StuName,string StuSurname,int StuAge,double StuAvgMark)
        {
           
            Name = StuName;
            SurName = StuSurname;
            Age = StuAge;
            AvgMark = StuAvgMark;
        }


    }
}
