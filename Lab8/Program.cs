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
            Console.WriteLine("Welcome to our C# class.");
            Console.Write("Which student would you like to learn more about?");

            
            Console.WriteLine("(enter a number 1-20): ");
            student = int.Parse(Console.ReadLine());

            for(int i = 0; i < 20; i++)
            {


            }




            

        }
        //Method Space

        
        public static string GetStudent(int studentNumber)
        {
            if(studentNumber > 0 && studentNumber <=20)
            {
                return Students()[studentNumber];
            }
            else
            {
                throw new Exception("That Student does not exist.");
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

       /* public static string StudentException(int studentNumber)
        {
            if(InClass(studentNumber))
            {
                return Students()[studentNumber - 1];               
            }
            else
            {
                throw new Exception("That student does not exist.");
            }
             
        }
        public static string HomeTown()
        {

        }
        public static string FavoriteFoodException()
        {

        }*/
    }
}
