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

                string[] StudentNames = new string[6] { "DAVID", "SAM", "TOD", "JUBIS", "SATAN", "MOSES" };
                string[] favoriteFood = new string[6] { "Cake", "Cookies", "Roast Beef", "Sushi", "Hellfire", "Sand" };
                string[] homeTown = new string[6] { "Detroit", "Lansing", "Djbouti", "Oaugadougu", "Hell", "The Desert" };

                Console.Write("Which student would you like to learn about? (Enter a number 1-6:");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine($"Student #{number} is {StudentNames[number - 1]}");
                    Console.WriteLine("=============");
                    while (true)
                    {
                        Console.WriteLine($"Do you want to know more about {StudentNames[number-1]}?");
                        Console.Write("Type in 'Favorite Food' or 'Hometown'(Check for proper capitalization); To exit type 'exit':");
                        var answer = Console.ReadLine();
                        if (answer == "Favorite Food")
                        {
                            Console.WriteLine($"{favoriteFood[number-1]} is {StudentNames[number-1]}'s favorite food.");
                        }
                        else if (answer == "Hometown")
                        {
                            Console.WriteLine($"{StudentNames[number-1]}'s hometown is {homeTown[number - 1]}");
                        }
                        else if(answer == "exit" )
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("That is invalid--Either 1)Favorite Food 2)Hometown 3)exit, THANK YOU.");
                        }
                    }
                    //Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Only input numbers from 1-6.");
                }
            }
        }
    }
}
