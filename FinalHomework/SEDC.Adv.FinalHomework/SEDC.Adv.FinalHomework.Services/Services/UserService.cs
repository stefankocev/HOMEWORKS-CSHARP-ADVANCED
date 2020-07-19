using SEDC.Adv.FinalHomework.Db.DataBase;
using SEDC.Adv.FinalHomework.Db.Entities;
using SEDC.Adv.FinalHomework.Db.Interfaces;
using SEDC.Adv.FinalHomework.Services.Helpers;
using SEDC.Adv.FinalHomework.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SEDC.Adv.FinalHomework.Services
{
    public class UserService : IUserService
    {
        private ILocalDb _db;
        public UserService()
        {
            _db = new LocalDb();
        }
        public User Login()
        {

            int timesTried = 3;
            while (timesTried > 0)
            {
                MessageHelper.ColoredMessage($"Be aware. You have {timesTried} times to try logging in.", ConsoleColor.Yellow);
                Console.WriteLine("Enter username:");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password:");
                string password = Console.ReadLine();

                User userLoggedIn = _db.GetAllUsers().FirstOrDefault(user => user.Username == username && user.Password == password);
                if (userLoggedIn != null)
                {
                    MessageHelper.ColoredMessage($"Welcome {userLoggedIn.FirstName}.You are successfully logged in.", ConsoleColor.Green);
                    
                    return userLoggedIn;
                }
                else
                {
                    timesTried--;
                    MessageHelper.ColoredMessage($"You have entered a wrong username or password.{timesTried} attempts left.", ConsoleColor.Red);
                }

            }
            MessageHelper.ColoredMessage("You have entered wrong username/password 3 times. The application is closing...", ConsoleColor.Red);
            Thread.Sleep(2000);
            return null;
        }

        public User Register()
        {
            User newUser = new User();
            Console.Write("Enter your name:");
            newUser.FirstName = ValidationHelper.ValidateString(Console.ReadLine());
            Console.Write("Enter your surname:");
            newUser.LastName = ValidationHelper.ValidateString(Console.ReadLine());
            Console.Write("How old are you?");
            newUser.Age = ValidationHelper.ValidateAge(Console.ReadLine());
            Console.Write("Enter Username(must be longer than 5 characters):");
            newUser.Username = ValidationHelper.ValidateString(Console.ReadLine());
            Console.Write("Enter Password(should contain at least one capital letter and one number):");
            newUser.Password = ValidationHelper.ValidatePassword(Console.ReadLine());

            if (newUser.FirstName == null ||
                newUser.LastName == null ||
                newUser.Age == 0 ||
                newUser.Username == null ||
                newUser.Password == null)
            {
                MessageHelper.ColoredMessage("There was something wrong with the registration.Try again!", ConsoleColor.Red);
                return null;
            }
            Console.WriteLine("Registering user...");
            Styles.Spiner();
            Thread.Sleep(2000);
            _db.InsertUser(newUser);
            MessageHelper.ColoredMessage("You are successfuly registered.", ConsoleColor.Green);
            return newUser;
        }
        public void ChangeInfo(int userId, string userName, string password)
        {
            User userFound = _db.GetUserById(userId);
            userFound.Username = userName;
            userFound.Password = password;
            MessageHelper.ColoredMessage("You have successfuly changed your info!", ConsoleColor.Green);
        }


    }
}
