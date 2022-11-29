using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_.Models
{
    public class UniMark
    {
        public int Midterm { get; set; }


        public UniMark(int midterm)
        {
            Midterm = midterm;
        }


        public static explicit operator SchoolMark(UniMark unimark)
        {
            SchoolMark schoolmark = new SchoolMark(unimark.Midterm / 20);
            return schoolmark;
        }





    }
}
