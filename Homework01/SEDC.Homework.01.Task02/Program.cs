using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Homework._01.Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TASK 1
            Console.WriteLine("Hello user.Please enter names.When you are done, click X");
            List<string> listOfNames = new List<string>();
            bool isValid = true;
            while (isValid)
            {
                string userInput = Console.ReadLine();
                if (userInput.ToLower() != "x")
                {
                    listOfNames.Add(userInput);
                }
                else
                {
                    isValid = !isValid;
                }
            }
            Console.WriteLine("Now, please enter a text.");
            string textInput = Console.ReadLine();
            List<string> textInputList = textInput.Split(" ").ToList();
            foreach (var name in listOfNames)
            {
                var times = textInputList.Where(userName => userName.ToLower().Contains(name.ToLower()));
                Console.WriteLine($"Name {name} appears {times.Count()} times in this text.");
            }
            #endregion


            Console.ReadLine();
        }
    }
}
