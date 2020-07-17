using SEDC.Adv.FinalHomework.Services.Helpers;
using SEDC.Adv.FinalHomework.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.FinalHomework.Services.AppMenus
{
    public class Menu : IMenu
    {
        public int MenuChoiceValidation(int range)
        {
            while (true)
            {
                var userInput = ValidationHelper.ValidateNumber(Console.ReadLine(), range);
                if (userInput == -1)
                {
                    MessageHelper.Color($"Wrong number entered.Enter a number between 1 and {range}", ConsoleColor.Red);
                    continue;
                }
                return userInput;
            }
        }

        public int StartMenu()
        {
            Console.WriteLine("Welcome to Time Track Application!");
            Console.WriteLine("Use the numbers in front of the selection to navigate thru the applicaton.");
            Console.WriteLine("1. Log In.");
            Console.WriteLine("2. Register.");
            Console.WriteLine("3. Exit application.");
            return MenuChoiceValidation(3);
        }
        public void MainMenu()
        {
            Console.WriteLine("Please choose one of the options");
            Console.WriteLine("1. Track Activity.");
            Console.WriteLine("2. Statistics.");
            Console.WriteLine("3. Account Management.");
            Console.WriteLine("4. Log Out.");
            MenuChoiceValidation(4);
        }
        public void TrackMenu()
        {
            Console.WriteLine("What are you doing today?");
            Console.WriteLine("1. Reading.");
            Console.WriteLine("2. Exercising.");
            Console.WriteLine("3. Working.");
            Console.WriteLine("4. Other hobbies.");
            Console.WriteLine("5. Go back.");
            MenuChoiceValidation(5);
        }
        public void ReadingMenu()
        {
            Console.WriteLine("What type of book are your reading today?");
            Console.WriteLine("1. Belles Lettres.");
            Console.WriteLine("2. Fiction.");
            Console.WriteLine("3. Professional Literature.");
            MenuChoiceValidation(3);
        }
        public void ExercisingMenu()
        {
            Console.WriteLine("What type of exercising are your doing today?");
            Console.WriteLine("1. General.");
            Console.WriteLine("2. Running.");
            Console.WriteLine("3. Sport.");
            MenuChoiceValidation(3);
        }
        public void WorkingMenu()
        {
            Console.WriteLine("Where are you working today from?");
            Console.WriteLine("1. Home");
            Console.WriteLine("2. At the office");
            MenuChoiceValidation(2);
        }
        public void AccountManagementMenu()
        {
            Console.WriteLine("1. Change password.");
            Console.WriteLine("2. Change First or Last Name.");
            Console.WriteLine("3. Deactivate account.");
            Console.WriteLine("4. Go back.");
            MenuChoiceValidation(4);
        }
        public void StatisticsMenu()
        {
            Console.WriteLine("Which statistics would you like to be shown?");
            Console.WriteLine("1. Reading.");
            Console.WriteLine("2. Exercising.");
            Console.WriteLine("3. Working.");
            Console.WriteLine("4. Other Hobbies.");
            Console.WriteLine("5. Global.");
            Console.WriteLine("6. Go back.");
            MenuChoiceValidation(6);
        }
    }
}
