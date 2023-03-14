using ConsoleApp16.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.Services
{
    internal class TeacherService
    {
        Teacher[] teachers = { };
        public void Create()
        {
            Teacher teacher = new Teacher();
            {
                Console.WriteLine("Enter the Name:");
                teacher.Name = Console.ReadLine();
            }

            Console.WriteLine("Enter the Surname:");
            teacher.Surname = Console.ReadLine();

            Console.WriteLine("Enter the Group Name:");
            teacher.GroupNo = Console.ReadLine();


            Array.Resize(ref teachers, teachers.Length + 1);
        }

    }
}
