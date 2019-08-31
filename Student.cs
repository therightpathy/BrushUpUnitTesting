using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushUpUnitTesting
{
    public enum Gender
    {
        Male,
        Female
    }
    public class Student
    {
        private string _name;
        private string _address;
        private int _semester;
        private Gender _gender;

        public string Name { get => _name; set => _name = value; }
        public string Address { get => _address; set => _address = value; }
        public int Semester { get => _semester; set => _semester = value; }

        public Gender Gender

        {
            get => _gender; set => _gender = value;
        }

        public Student(string name, string address, int semester, Gender gender)
        {
            CheckName(name);
            CheckAddress(address);
            CheckSemester(semester);
            Name = name;
            Address = address;
            Semester = semester;
            Gender = gender;
        }

        private static bool CheckName(string name)
        {
            if (name.Length < 2)
            {
                throw new ArgumentException("Name is shorter than two characters");
            }

            return true;
        }

        private static void CheckAddress(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                throw new ArgumentException("Address is null or empty");
            }
        }

        public static void CheckSemester(int semester)
        {
            if (semester < 1)
            {
                throw new ArgumentOutOfRangeException("semester", semester, "Semester must be between 1-8");
            }

            if (semester > 8)
            {
                throw new ArgumentOutOfRangeException("semester", semester, "Semester must be between 1-8");
            }
        }

        public override string ToString()
        {
            return string.Format("Student({0}, {1}, {2})", Name, Address, Semester);
        }

    }
}
