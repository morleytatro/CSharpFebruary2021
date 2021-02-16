using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqIntro
{
    public class Student
    {
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string Email {get;set;}
        public int FavoriteNumber {get;set;}

        // constructor
        public Student(string first, string last, string email, int favNumber)
        {
            FirstName = first;
            LastName = last;
            Email = email;
            FavoriteNumber = favNumber;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}; {Email}; Favorite Number: {FavoriteNumber}";
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>() {
                new Student("Andy", "Rocha", "andy@rocha.com", 41),
                new Student("Anthony", "Ngo", "anthony@ngo.com", 82),
                new Student("Bianca", "Casem", "bianca@casem.com", 41),
                new Student("CJ", "Triebels", "cj@triebels.com", 49),
                new Student("Enoch", "Strok", "enoch@strok.com", 24),
                new Student("Ermes", "Natale", "ermes@natale.com", 61),
                new Student("Hiba", "Mohiuddin Ali", "hiba@mohiuddin ali.com", 54),
                new Student("John", "Albert", "john@albert.com", 4),
                new Student("John", "Paterson", "john@paterson.com", 97),
                new Student("Joe", "Lee", "joe@lee.com", 77),
                new Student("Joe", "Silva", "joe@silva.com", 17),
                new Student("Klint", "Amoguis", "klint@amoguis.com", 96),
                new Student("Kyle", "Marymee", "kyle@marymee.com", 55),
                new Student("Ling", "Xu", "ling@xu.com", 34),
                new Student("Maddie", "Houvener", "maddie@houvener.com", 13),
                new Student("Mert", "Myers", "mert@myers.com", 13),
                new Student("Nick", "Grishchuk", "nick@grishchuk.com", 55),
                new Student("Ian", "Rones", "ian@rones.com", 90),
                new Student("Quinn", "Lathe", "quinn@lathe.com", 91),
                new Student("Rachel", "Lorentson", "rachel@lorentson.com", 19),
                new Student("Spencer", "Huyck", "spencer@huyck.com", 20),
                new Student("Sujung", "Choi", "sujung@choi.com", 16),
                new Student("Tino", "Taitano", "tino@taitano.com", 28),
                new Student("Vic", "Gargurevich", "vic@gargurevich.com", 100),
                new Student("Will", "Segovia", "will@segovia.com", 17),
                new Student("Zach", "Munson", "zach@munson.com", 95),
                new Student("Zack", "Springer", "zack@springer.com", 62)
            };

            // The methods below DO NOT alter the original list!

            // Linq queries here!
            IEnumerable<Student> sortedByFavoriteNumber = students
                .OrderBy(stud => stud.FavoriteNumber)
                .ToList();
            // when we're returning a property value, it is a "selector"
            
            // foreach(var student in sortedByFavoriteNumber)
            // {
            //     Console.WriteLine(student);
            // }

            var studentsWithFirstNameM = students
                .Where(stud => stud.FirstName.StartsWith("M"));
                // .ToList();

            var studentsWithFavNumberOver50 = students
                .Where(student => student.FavoriteNumber > 50);
            // our anonymous function takes in an object
            // and returns out a boolean
            // this is called a "predicate" function


            var favNum13 = students.FirstOrDefault(student => student.FavoriteNumber == 1);

            // Console.WriteLine(favNum13 == null);

            var lastNames = students.Select((student, index) => {
                // you can even access the item's index if needed!
                return $"{student.LastName} - {index}";
            });

            foreach(var last in lastNames)
            {
                Console.WriteLine(last);
            }

            var sumFavNumbers = students.Sum(student => student.FavoriteNumber);

            Console.WriteLine($"The sum of favorites is {sumFavNumbers}");

            var firstNameJByFavoriteNumber = students
                .Where(student => student.FirstName.StartsWith("J")) // filters the list
                .OrderBy(student => student.FavoriteNumber); // sorts them by favorite number
            // this is "chaining"
            
            foreach(var student in firstNameJByFavoriteNumber)
            {
                Console.WriteLine(student);
            }
        }
    }
}
