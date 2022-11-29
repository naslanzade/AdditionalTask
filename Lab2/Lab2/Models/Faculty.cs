using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Models
{
    class Faculty
    {
        public static int Id { get; set; }
        public string Name { get; set; }
       


        public Faculty(string FacultyName)
        {
           
            Name = FacultyName;
        }


    }
}
