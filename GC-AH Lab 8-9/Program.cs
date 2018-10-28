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

                string[] StudentNames = new string[3] { "DAVID", "SAM", "TOD" };
                string[] favoriteFood = new string[3] { "Cake", "Cookies", "Roast Beef" };
                string[] homeTown = new string[3] { "Detroit", "Lansing", "Djbouti" };
                Console.WriteLine("Please enter a number:");
                //int number = Convert.ToInt32(Console.ReadLine());
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    while (true)
                    {
                        Console.WriteLine(StudentNames[number - 1]);
                        Console.WriteLine("Want more info?(Favorite food/Hometown) or no to leave.");
                        var answer = Console.ReadLine();
                        if (answer == "Favorite Food")
                        {
                            Console.WriteLine(favoriteFood[number-1]);
                        }
                        else if (answer == "Hometown")
                        {
                            Console.WriteLine(homeTown[number - 1]);
                        }
                        else if(answer == "no" )
                        {
                            break;
                        }
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
