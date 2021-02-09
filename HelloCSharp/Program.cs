using System; // like an import statement
using System.Collections.Generic;

namespace HelloCsharp
{
    class Program
    {
        // this is the entrypoint to the app
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }

            // Math myMathInstance = new Math();
            int result = Math.Add(1, 2);

            string myName = "Morley Tatro";

            // string interpolation
            Console.WriteLine($"My name is {myName}");

            // int myInt = 5;

            // don't do this!
            // myInt = "some string";

            int[] myArray = { 1, 2, 3, 4 };

            myArray[2] = 5;
            // myArray[4] = 100;

            foreach(int item in myArray)
            {
                Console.WriteLine($"The value is {item}");
            }

            List<string> students = new List<string>();

            students.Add("Nick");
            students.Add("CJ");
            students.Add("Tino");

            students.Remove("CJ");

            foreach(string student in students)
            {
                Console.WriteLine($"The student's name is {student}");
            }

            Console.WriteLine($"There are {students.Count} students!");

            Dictionary<string, object> myDictionary = new Dictionary<string, object>();

            myDictionary.Add("Age", 25);
            myDictionary.Add("Name", "Morley");

            for(int i = 1; i <= 200; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"{i} is divisible by 15!");
                }
            }
        }

    }

    class Math
    {
        // static keyword allows us to call the function directly from the class
        // typically for utility functions
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
