using Lab_.Models;
using System;

namespace Lab_
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task

            //Products laptop = new Laptop();
            //Products product = laptop;

            //Products patato = new Patato();
            //Products products = patato;

            //Products[] produtcs1 = { laptop, patato };
            //foreach (var item in produtcs1)
            //{
            //    Laptop laptop1 = item as Laptop;

            //    if (laptop1!=null)
            //    {
            //        Console.WriteLine(laptop1.Laptop1());
            //    }
            //}



            //foreach (var item in produtcs1)
            //{
            //    if (item is Laptop L)
            //    {
            //        Console.WriteLine(L.Laptop1());
            //    }
            //}



            //UniMark uniMark = new UniMark(95);
            //SchoolMark schoolmark =(SchoolMark) uniMark;
            //Console.WriteLine(schoolmark.Ksq);
            #endregion



            #region Task2                      

            Student stu1 = new Student("Gultac", "Ceferova", false, 66);
            Student stu2 = new Student("Anar", "Huseynov", false, 65);

            Group group1 = new Group(414);
            Group group2 = new Group(130);
            group1.Add(stu1);
            group1.Add(stu2);

            //foreach (var item in group1.students)
            //{
            //    Console.WriteLine($"{item.Id} {item.Name}");
            //}
            Faculty faculty1 = new Faculty("Tetbiq");
            Faculty faculty2 = new Faculty("Muhendis");
            faculty1.Add(group1);
            faculty1.Add(group2);

            faculty2.Add(group1);
            faculty2.Add(group2);
            // faculty1.GetGroups();

            University uni1 = new University("BDU");

            uni1.Add(faculty1);
            uni1.Add(faculty2);

            foreach (var item in uni1.GetFaculties())
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }

            #endregion







        }
    }
}
