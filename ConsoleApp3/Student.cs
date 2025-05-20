using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Student
    {
        // internal
        public string Name;
        public int Grade;
        public string result;
    }
    static class UpdateStudent
    {
        public static void UpdateStudentName(Student student)
        {
            Console.WriteLine("Enter student's name");
            student.Name = Console.ReadLine();
        }
        public static void UpdateStudentGrade(Student student)
        {
            Console.WriteLine("Enter student's grade");
            student.Grade = int.Parse(Console.ReadLine());
        }
    }
}