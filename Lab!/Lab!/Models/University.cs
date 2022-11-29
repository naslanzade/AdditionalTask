using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_.Models
{
    class University 
    {
        public int Id { get; set; }
        static int _id = 0;
        public Faculty[] faculties;

        public string Name { get; set; }

        public University(string name)
        {
            Name = name;
            _id++;
            Id = _id;

            faculties = new Faculty[0];
        }

        public void Add(Faculty faculty)
        {
            Array.Resize(ref faculties, faculties.Length + 1);
            faculties[faculties.Length - 1] = faculty;
        }

        public Faculty[] GetFaculties()
        {
            return faculties;
        }
    }
}
