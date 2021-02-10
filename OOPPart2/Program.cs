using System;
using System.Collections.Generic;

namespace OOPPart2
{
    // interface acts as a blueprint for the blueprints (classes)
    // it enforces a contract between behavior we want and classes that implement it
    interface INameable
    {
        // this is a method signature
        public void sayMyName();
        // make sure that we can say the name
    }

    class Program
    {
        static void Main(string[] args)
        {
            var ermes = new Student("Ermes", "Natale");
            ermes.sayMyName();

            ermes.addCourse(new Course("Python", "Edward Im"));
            ermes.addCourse(new Course("C#", "Morley Tatro"));

            Console.WriteLine(ermes.Courses.Count);
        }
    }

    public class Dog : INameable
    {
        public string Name {get;set;}

        public Dog(string n)
        {
            Name = n;
        }

        public void sayMyName()
        {
            Console.WriteLine($"I'm a dog and my name is {Name}.");
        }
    }

    // Human "implements" the INameable interface
    public class Human : INameable
    {
        // properties
        public string FirstName {get;set;}
        public string LastName {get;set;}

        public Human(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }

        public void sayMyName()
        {
            Console.WriteLine($"My name is {FirstName} {LastName}!");
        }
    }

    // Student inherits from the Human class
    public class Student : Human
    {
        // property
        public List<Course> Courses {get;set;}

        // constructor
        public Student(string fName, string lName) : base(fName, lName) // base calls the parent's constructor
        {
            Courses = new List<Course>();
        }

        // method
        public List<Course> addCourse(Course c) // parameter
        {
            Courses.Add(c);
            return Courses; // returning the student's course list
        }
    }

    public class Course
    {
        public string Language {get;set;}
        public string Teacher {get;set;}
        
        public Course(string lang, string teach)
        {
            Language = lang;
            Teacher = teach;
        }
    }
}
