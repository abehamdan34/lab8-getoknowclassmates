using System;

namespace lab8_GetToKnowYourClassMates
{
    class Program
    {
        static void Main(string[] args)
        {
            //created the arrays each row correlates with each other vertically.
            string[] names = { "Abe Hamdan", "John Apple", "Megan Banana", "Jessica Hog" };
            string[] hometowns = { "Dearborn, MI", "Dallas, TX", "Detroit, MI", "Orlando, FL" };
            string[] favoriteFood = { "French Fries", "Apples", "Bananas", "Tacos" };
            //Labeling variables
            bool notValid = true;
            bool moreInfo = true;
            //making choice 0 means the users choice for index has to -1 so that it gives the correct array element
            int choice = 0;
            string name = "";
            //while loop that is trying to parse changing the string to a number and checks the index number is out of range
            while (notValid)
            {
                try
                {
                    Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (enter a number 1 - 4): ");
                    choice = int.Parse(Console.ReadLine());
                    name = names[choice - 1];
                    notValid = false;
                }
                catch (Exception ex)
                {
                    if ((ex is IndexOutOfRangeException) || (ex is FormatException)) {
                        notValid = true;
                        Console.WriteLine("That is not a valid input, please try again.");
                    }
                }
            }
            //while loop validating if the user inputs the correct string and if not re prompts them
            while (moreInfo)
            {
                Console.WriteLine($"Student {choice} is {name}. What would you like to know about {name}? (enter “hometown” or “favorite food”): ");
                string input = Console.ReadLine();
                string chooseAgain = "";
                if (input != "hometown" && input != "favorite food")
                {
                    moreInfo = true;
                } else
                {
                    if (input == "hometown")
                    {
                        string hometown = hometowns[choice - 1];
                        Console.WriteLine($"{name} is from {hometown}. Would you like to know more? (enter “yes” or “no”): ");                        
                    } 
                    else
                    {
                        string food = favoriteFood[choice - 1];
                        Console.WriteLine($"{name}'s favorite food is {food}. Would you like to know more? (enter “yes” or “no”): ");
                    }
                    //string choose again if yes will prompt another question if no ends program
                    chooseAgain = Console.ReadLine();
                    
                    if (chooseAgain == "no")
                    {
                        moreInfo = false;
                    }
                }
            }
        }
    }
}
