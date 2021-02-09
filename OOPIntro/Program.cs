using System;
using System.Collections.Generic;

namespace OOPIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Student kyle = new Student("Kyle", "Marymee");
            Student ian = new Student("Ian", "Rones", 100);
            Console.WriteLine(kyle.firstName);
            // ian.energy = 40;

            // Console.WriteLine(kyle);
            List<Student> students = new List<Student>() {
                kyle,
                ian
            };

            // notice the type inference
            foreach(var stud in students)
            {
                Console.WriteLine(stud);
            }
        }
    }

    public class Student
    {
        // these are fields
        public string firstName;
        public string lastName;
        public int energy;

        // example of a property
        public string FullName {
            // note that it is derived
            // we can't set it directly
            get
            {
                return $"{firstName} {lastName}";
            }
        }

        // constructor
        public Student(string fName, string lName, int en = 50)
        {
            // this runs every time we create a student!
            firstName = fName;
            lastName = lName;
            energy = en;
        }

        // optional override so we can see useful info
        public override string ToString()
        {
            return $"{FullName} has {energy} energy.";
        }
    }
}
