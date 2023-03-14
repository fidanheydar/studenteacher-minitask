using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.Models
{
    internal abstract class Person
    {

        public readonly int Id;
        private static int _count = 0;
        string _name;
        string _surname;
        string _groupNo;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length >= 3 && value.Length <= 30)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Name must be min 3 ,max 30 characters");
                }
            }

        }

        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value.Length >= 3 && value.Length <= 30)
                {
                    _surname = value;
                }
                else
                {
                    Console.WriteLine("Name must be min 3 ,max 30 characters");
                }
            }

        }
        public string GroupNo
        {
            get { return _groupNo; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _groupNo = value;
                }
            }
        }
        public Person()
        {
            _count++;
            Id = _count;
        }
        public override string ToString()
        {
            return $"Name : {Name} , Surname : {Surname} , GroupNO : {GroupNo},Id: {Id}";

        }

    }
}
