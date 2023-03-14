using ConsoleApp16.Interfaces;
using ConsoleApp16.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.Services
{
    internal class StudentService:IStudentService
    {
        Student[] students = { };
        public void Create()
        {
            Student student = new Student();
            {
                Console.WriteLine("Enter the Name:");
                student.Name = Console.ReadLine();
            }

            Console.WriteLine("Enter the Surname:");
            student.Surname = Console.ReadLine();

            Console.WriteLine("Enter the Group Name:");
            student.GroupNo = Console.ReadLine();

            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }
        internal void GetById()
        {
            Console.WriteLine("Enter Id: ");
            int Id = int.Parse(Console.ReadLine());
            foreach (Student student in students)
            {
                if (student.Id == Id)
                {
                    Console.WriteLine(Id);
                }
            }
        }
        public void Show()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

        }

    }
}

