using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_AH_Lab_8_9
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                List<string> StudentNames = new List<string> { "DAVID", "SAM", "TOD", "JUBIS", "SATAN", "MOSES" };
                List<string> favoriteFood = new List<string> { "Cake", "Cookies", "Roast Beef", "Sushi", "Hellfire", "Sand" };
                List<string> homeTown = new List<string> { "Detroit", "Lansing", "Djbouti", "Oaugadougu", "Hell", "The Desert" };
                //homeTown.Add("foo");
                //homeTown.Add(Console.ReadLine());
                Console.Write("Would you like to learn about a student?(Enter a number 1-6) -OR- Would you like to add a student to the directory?(y/n):");
                var add = Console.ReadLine();
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine($"Student #{number} is {StudentNames[number - 1]}");
                    Console.WriteLine("=============");
                    while (true)
                    {
                        Console.WriteLine($"Do you want to know more about {StudentNames[number - 1]}?");
                        Console.Write("Type in 'Favorite Food' or 'Hometown'(Check for proper capitalization); To exit type 'exit':");
                        var answer = Console.ReadLine();
                        if (answer == "Favorite Food")
                        {
                            Console.WriteLine($"{favoriteFood[number - 1]} is {StudentNames[number - 1]}'s favorite food.");
                        }
                        else if (answer == "Hometown")
                        {
                            Console.WriteLine($"{StudentNames[number - 1]}'s hometown is {homeTown[number - 1]}");
                        }
                        else if (answer == "exit")
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("That is invalid--Either 1)Favorite Food 2)Hometown 3)exit, THANK YOU.");
                        }
                    }
                }
                else if (add != "y")
                {
                    Console.WriteLine("Please enter the students name:");
                    StudentNames.Add(Console.ReadLine());
                }
                //else
                //{
                //    Console.WriteLine("Only input numbers from 1-6.");
                //}
            }
        }
    }
}
