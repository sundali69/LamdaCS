using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_exercises
{
    internal class Program
    {
        public class Student
        {
            public string Name { get; set; }
            public double GPA { get; set; }
        }
        static void Main(string[] args)
        {

            var students = new List<Student>
            {
                new Student { Name = "Alice", GPA = 3.6 },
                new Student { Name = "Bob", GPA = 3.2 },
                new Student { Name = "Charlie", GPA = 3.8 }

            };
            List<string> result = LinqSorting_FilteringData(students);

            //foreach (string str in result)
            //    Console.WriteLine(str);

            result.ForEach(Console.WriteLine);
        
        }

        public static List<string> LinqSorting_FilteringData(List<Student> students)
        {
            List<string> result=  students
                    .Where(student => student.GPA > 3.5)
                    .OrderByDescending(student => student.GPA)
                    .Select(student => student.Name + ","+ student.GPA)
                    .ToList();
            return result;
        }

           

    }

}
