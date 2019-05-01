
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that will recognize invalid inputs when the user requests information about students in a class
             *
             * What will the application do?
             * -Provide information about students in a class
             * -Prompt the user to ask about a particular student
             * -Give proper responses according to user-submitted information
             * -Ask if user would like to learn about another student
             * 
             * Build Specifications:
             * 1) Account for invalid user input with exceptions
             * 2) Try to incorporate IndexOutOfRangeException and FormatException
             * 
             * **Hint** Make it easy for the user -- tell them what information is available
             */

            int student;
            string firstChoice, secondChoice;

            Console.WriteLine("Welcome to our C# class.");
            Console.Write("Which student would you like to learn more about?");

            student = CheckStudent();


            Console.WriteLine($"Student {student} is {Students()[student - 1]}");


            Console.WriteLine($"What would you like to know about {Students()[student - 1]}?");
            firstChoice = Console.ReadLine();

            if (firstChoice.ToLower() != "hometown" && firstChoice.ToLower() != "favorite food")
            {

                firstChoice = CheckFirstChoice();
                
            }

            if (firstChoice.ToLower() == "hometown")
            {
                Console.Write($"{Students()[student - 1]} is from {HomeTown()[student - 1]}.");
                Console.WriteLine(" \nWould you like to know more? (enter \"yes\" or \"no\")");
                secondChoice = Console.ReadLine();

                if (secondChoice.ToLower() == "yes")
                {
                    Console.WriteLine($"{Students()[student - 1]}'s favorite food is {FavFood()[student - 1]}.");
                }
            }
            else if (firstChoice.ToLower() == "favorite food")
            {
                Console.Write($"{Students()[student - 1]}'s favorite food is {FavFood()[student - 1]}.");
                Console.WriteLine(" \nWould you like to know more? (enter \"yes\" or \"no\")");
                secondChoice = Console.ReadLine();

                if (secondChoice.ToLower() == "yes")
                {
                    Console.WriteLine($"{Students()[student - 1]} is from {HomeTown()[student - 1]}.");
                }
            }

            Console.WriteLine("Thanks!");


        }

        //Method Space

        public static int CheckStudent()
        {
            Console.WriteLine("\n(enter a number 1-20): ");
            int student;
            bool isNum = int.TryParse(Console.ReadLine(), out student);

            if (student < 1 || student > 20)
            {
                Console.WriteLine("That student does not exist. Please try again.");
                return CheckStudent(); 
            }
            else if(!isNum)
            {
                Console.WriteLine("That student does not exist. Please try again.");
                return CheckStudent();
            }
            return student;

        }
        public static string CheckFirstChoice()
        {
            Console.WriteLine($"Please try again. \n(enter \"hometown\" or \"favorite food\")");
            string choice = Console.ReadLine();

            if (choice.ToLower() != "hometown" && choice.ToLower() != "favorite food")
            {
                return CheckFirstChoice(); 
            }
            else if (choice.ToLower() == "hometown")
            {
                return "hometown";
            }
            else
            {
                return "favorite food";
            }
        }

        public static string[] Students()
        {
            string[] students = { "Pikachu", "Bulbasaur", "Charmander", "Squirtle", "Ivysaur", "Charmeleon", "Wartortle",
                "Venesaur", "Charizard", "Blastoise", "MewTwo", "Articuno", "Moltres", "Zapdos", "Slowbro", "Slowpoke",
                "Kabuto", "Kabutops", "Lugia", "Ho-oh" };

            return students;
        }

        public static string[] HomeTown()
        {
            string[] homeTowns = {"Pewter City","Saffron City","Pallet Town",
                "Fuchsia City","Goldenrod City", "Cerulean City", "Vermillion City",
                "Lavender Town", "Celadon City", "Cinnabar Island", "Diglett's Cave",
                "Indigo Plateau", "Mt. Moon", "Safari Zone", "Seafoam Islands", "Victory Road",
                "Viridian Forest", "Cerulean Cave", "Rock Tunnel", "Pokemon Mansion"};

            return homeTowns;
        }

        public static string[] FavFood()
        {
            string[] favFood = {"Sushi","Pizza","Pasta","Burritos","Bananas", "Ice Cream",
                "Fried Rice", "Pulled Pork", "Steak", "Hot Dogs", "Cheeseburger","Pineapple",
                "Cake", "Pie","Chicken", "Salad", "Cotton Candy", "Donuts", "Calzone", "Lasagna" };

            return favFood;
        }
    }
}