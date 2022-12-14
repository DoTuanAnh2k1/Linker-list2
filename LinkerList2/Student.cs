using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkerList2
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public GenderInfo Gender { get; set; }
        public string Class { get; set; }
        public Student() { }
        public Student(int id, string name, DateTime dob, GenderInfo gender, string @class)
        {
            Id = id;
            Name = name;
            Dob = dob;
            Gender = gender;
            Class = @class;
        }

        public void Print()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Date of birth: " + Dob);
            Console.WriteLine("Gender: " + Gender);
            Console.WriteLine("Class: " + Class);
        }
    }
}
