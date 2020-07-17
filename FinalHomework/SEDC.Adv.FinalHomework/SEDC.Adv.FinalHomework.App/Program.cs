using SEDC.Adv.FinalHomework.Db.DataBase;
using SEDC.Adv.FinalHomework.Db.Entities;
using SEDC.Adv.FinalHomework.Db.Interfaces;
using SEDC.Adv.FinalHomework.Services;
using SEDC.Adv.FinalHomework.Services.AppMenus;
using SEDC.Adv.FinalHomework.Services.Interfaces;
using SEDC.Adv.FinalHomework.Services.Services;
using System;

namespace SEDC.Adv.FinalHomework.App
{
    class Program
    {
        public static IMenu menu = new Menu();
        public static User user = new User();
        public static ILocalDb userDb = new LocalDb();
        public static IUserService userService = new UserService();
        public static IActivityService activityService = new ActivityService();
        public static ReadingService<Reading> readingService = new ReadingService<Reading>();
        public static ExercisingService<Exercising> exercisingService = new ExercisingService<Exercising>();
        public static WorkingService<Working> workingService = new WorkingService<Working>();
        public static OtherHobbyService<OtherHobby> otherHobbyService = new OtherHobbyService<OtherHobby>();

        static void Main(string[] args)
        {
            while (true)
            {
                int userInput = menu.StartMenu();
                while (true)
                {
                   
                    if (userInput == 1)
                    {
                        user = userService.Login();
                        if (user == null)
                        {
                            Environment.Exit(0);
                        }
                        break;
                     
                    }
                    else if (userInput == 2)
                    {
                        user = userService.Register();
                        if (user == null)
                        {
                            continue;
                        }
                        break;
                       
                    }
                }
               
                Console.Clear();
                Console.ReadLine();
            }
           
            
        }
    }
}
