using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_ClassAndObject
{
    public class Student
    {
        private int studId;
        private String studName;

        public Student()//Default Constructor
        {
              studId = 1;
            studName = "Suraj";
        }

        public Student(int id,String name)//parametrized Constructor
        {
            this.studId = id;//this keyword refers instance variable/data member
            this.studName = name;
        }

        public String Display()
        {
            return $"\nStudent Details: \nStudent ID: {studId} \nStudent Name: {studName}";
        }
    }
}
