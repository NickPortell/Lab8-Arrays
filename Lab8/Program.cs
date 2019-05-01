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

            //string res = "y";

            int student;
            string firstChoice, secondChoice;
            bool repeat = true;

            Console.WriteLine("Welcome to our C# class.");
            Console.Write("Which student would you like to learn more about?");


            while (repeat == true)
            {
                try
                {

                    student = CheckStudent();
                    repeat = false;

                    Console.WriteLine($"Student {student} is {Students()[student - 1]}");


                    Console.WriteLine($"What would you like to know about {Students()[student - 1]}?");
                    firstChoice = Console.ReadLine();

                    if (firstChoice.ToLower() != "hometown" && firstChoice.ToLower() != "favorite food")
                    {
                        
                        throw new InvalidOperationException("That data does not exist. Please try again. (enter \"hometown\" or \"favorite food\")");
                    }
                    
                    


                    if (firstChoice.ToLower() == "hometown")
                    {
                        Console.Write($"{Students()[student - 1]} is from {HomeTown()[student - 1]}.");
                        Console.WriteLine(" Would you like to know more? (enter \"yes\" or \"no\")");
                        secondChoice = Console.ReadLine();

                        if (secondChoice.ToLower() == "yes")
                        {
                            Console.WriteLine($"{Students()[student - 1]}'s favorite food is {FavFood()[student - 1]}.");
                        }
                    }
                    else if (firstChoice.ToLower() == "favorite food")
                    {
                        Console.Write($"{Students()[student - 1]}'s favorite food is {FavFood()[student - 1]}.");
                        Console.WriteLine(" Would you like to know more? (enter \"yes\" or \"no\")");
                        secondChoice = Console.ReadLine();

                        if (secondChoice.ToLower() == "yes")
                        {
                            Console.WriteLine($"{Students()[student - 1]} is from {HomeTown()[student - 1]}.");
                        }
                    }

                    Console.WriteLine("Thanks!");

                   
                }
                catch (InvalidOperationException invalid)
                {
                    Console.WriteLine(invalid.Message);
                }

                
            }

        } 
               


                

            


            

        
        //Method Space
        public static bool IsStudent(int student)
        {
            if (student > 0 && student <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int CheckStudent()
        {
            Console.WriteLine("\n(enter a number 1-20): ");
            int student = int.Parse(Console.ReadLine());

            if (student < 1 || student > 20)
            {
                throw new InvalidOperationException("That Student does not exist. Please try again.");
            }
            return student;
            
        }
        //public static string CheckFirstChoice(string choice)
        //{
        //    Console.WriteLine($"What would you like to know about {Students()[student - 1]}?");
        //    string choice = Console.ReadLine();

        //    if (choice.ToLower() != "hometown" && choice.ToLower() != "favorite food")
        //    {
        //        throw new InvalidOperationException("That data does not exist. Please try again. (enter \"hometown\" or \"favorite food\")");
        //    }
        //    return choice;
        //}

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
