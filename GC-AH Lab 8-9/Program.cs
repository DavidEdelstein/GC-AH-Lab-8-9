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
                // James - Nice, I see you are getting used to using arrays! good job.  I would take it up a notch
                // and maybe consier using Lists instead, and take that EVEN FURTHER and use a list of Student, where
                // a student is an object instantiated from the Student class, which you can create yourself!
                string[] StudentNames = new string[6] { "DAVID", "SAM", "TOD", "JUBIS", "SATAN", "MOSES" };
                string[] favoriteFood = new string[6] { "Cake", "Cookies", "Roast Beef", "Sushi", "Hellfire", "Sand" };
                string[] homeTown = new string[6] { "Detroit", "Lansing", "Djbouti", "Oaugadougu", "Hell", "The Desert" };

                Console.Write("Which student would you like to learn about? (Enter a number 1-6:");
                // James - for a user experience, why not print out each student in the console so the user at least 
                // knows which students he/she can view
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine($"Student #{number} is {StudentNames[number - 1]}");
                    Console.WriteLine("=============");
                    while (true)
                    {
                        // James - I like that you are getting the student information in each arrays
                        // by index, very clever!
                        Console.WriteLine($"Do you want to know more about {StudentNames[number-1]}?");
                        Console.Write("Type in 'Favorite Food' or 'Hometown'(Check for proper capitalization); To exit type 'exit':");
                        var answer = Console.ReadLine();
                        // James - for string comparison, I would use the Equals method attached to a string object. 
                        // like "answer.Equals("Favorite Food", StringComparison.OrdinalIgnoreCase);
                        // that way the user won't have to worry about casing.  
                        // ALSO for a user experience, I would consider reducing what the user has to input, 
                        // you will find the more you request of a user, the greater the change a user can mess it up, so 
                        // maybe just chekcing for the letter F or letter H, or just Food, or Town.
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
