using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNinja = new Ninja();
            var firstBuffet = new Buffet();

            // only eat while not true
            while(firstNinja.IsFull != true)
            {
                var food = firstBuffet.Serve(); // returns a random food item
                firstNinja.Eat(food);
            }

            firstNinja.Eat(firstBuffet.Serve()); // testing our console warning
        }
    }

    public class Food
    {
        // fields
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy; 
        public bool IsSweet; 
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet

        // runs when we create a new instance
        public Food(string nameParam, int calParam, bool isSpicyParam, bool isSweetParam)
        {
            Name = nameParam;
            Calories = calParam;
            IsSpicy = isSpicyParam;
            IsSweet = isSweetParam;
        }
    }

    public class Buffet
    {
        public List<Food> Menu;
     
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Example", 1000, false, false),
                new Food("Avocado Toast", 400, false, false),
                new Food("Tacos", 700, true, false),
                new Food("Pizza", 3000, true, false)
            };

            // var myArray = [1, 2, 3, 4, 5] in JS
        }
     
        public Food Serve()
        {
            var rand = new Random();
            var randomIndex = rand.Next(Menu.Count); // optional to include the low number

            return Menu[randomIndex];
        }

    }

    public class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        
        // add a constructor
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        
        // add a public "getter" property called "IsFull"
        public bool IsFull {
            get
            {
                if(calorieIntake > 1200)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        
        // build out the Eat method
        public void Eat(Food item)
        {
            if(IsFull)
            {
                Console.WriteLine("The ninja is full and can't eat!");
            }
            else
            {
                // adds calorie value to ninja's total calorieIntake
                calorieIntake += item.Calories;

                // adds the randomly selected Food object to ninja's FoodHistory list
                FoodHistory.Add(item);

                // writes the Food's Name - and if it is spicy/sweet to the console
                Console.WriteLine($"The food is {item.Name}; Spicy: {item.IsSpicy}; Sweet: {item.IsSweet}");
            }
        }
    }
}
