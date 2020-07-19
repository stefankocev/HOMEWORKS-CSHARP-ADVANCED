using SEDC.Adv.FinalHomework.Db.DataBase;
using SEDC.Adv.FinalHomework.Db.Entities;
using SEDC.Adv.FinalHomework.Db.Interfaces;
using SEDC.Adv.FinalHomework.Services;
using SEDC.Adv.FinalHomework.Services.AppMenus;
using SEDC.Adv.FinalHomework.Services.Helpers;
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
                bool main = false;
                while (!main)
                {
                    int mainMenu = menu.MainMenu();
                    switch (mainMenu)
                    {
                        case 1:
                            bool track = false;
                            while (!track)
                            {
                                int trackMenu = menu.TrackMenu();
                                switch (trackMenu)
                                {
                                    case 1:
                                        Reading reading = new Reading();
                                        reading.Stopwatch = activityService.TrackActivity("reading");
                                        Console.WriteLine("Enter the number of page you read");
                                        reading.Pages = int.Parse(Console.ReadLine());
                                        int readingMenu = menu.ReadingMenu();
                                        switch (readingMenu)
                                        {
                                            case 1:
                                                reading.Type = Db.Enums.ReadingType.BellesLettras;
                                                break;
                                            case 2:
                                                reading.Type = Db.Enums.ReadingType.Fiction;
                                                break;
                                            case 3:
                                                reading.Type = Db.Enums.ReadingType.ProffesionalLiterature;
                                                break;
                                        }
                                        readingService.AddReadingActivity(reading);
                                        Console.WriteLine($"{user.Username} you read total of {reading.Pages}, from {reading.Type} type of book, for {reading.Stopwatch.Elapsed.TotalMinutes} minutes");
                                        break;
                                    case 2:
                                        Exercising exercise = new Exercising();
                                        exercise.Stopwatch = activityService.TrackActivity("exercising");
                                        int exerciseMenu = menu.ExercisingMenu();
                                        switch (exerciseMenu)
                                        {
                                            case 1:
                                                exercise.Type = Db.Enums.ExercisingType.General;
                                                break;
                                            case 2:
                                                exercise.Type = Db.Enums.ExercisingType.Running;
                                                break;
                                            case 3:
                                                exercise.Type = Db.Enums.ExercisingType.Sport;
                                                break;
                                        }
                                        exercisingService.AddExercisingActivity(exercise);
                                        Console.WriteLine($"{user.Username} you did {exercise.Type} for {exercise.Stopwatch.Elapsed.TotalMinutes} minutes");
                                        break;
                                    case 3:
                                        Working working = new Working();
                                        working.Stopwatch = activityService.TrackActivity("working");
                                        int workingMenu = menu.WorkingMenu();
                                        switch (workingMenu)
                                        {
                                            case 1:
                                                working.WorkFrom = Db.Enums.WorkingType.Home;
                                                break;
                                            case 2:
                                                working.WorkFrom = Db.Enums.WorkingType.Office;
                                                break;
                                        }
                                        workingService.AddWorkingActivity(working);
                                        Console.WriteLine($"{user.Username} you worked from {working.WorkFrom} for {working.Stopwatch.Elapsed.TotalMinutes} minutes");
                                        break;
                                    case 4:
                                        Console.WriteLine("Tell me what did you do today:");
                                        OtherHobby otherHobby = new OtherHobby();
                                        otherHobby.HobbyName = Console.ReadLine();
                                        otherHobby.Stopwatch = activityService.TrackActivity(otherHobby.HobbyName);
                                        otherHobbyService.AddOtherHobbyActivity(otherHobby);
                                        Console.WriteLine($"{user.Username}, you've been doing {otherHobby.HobbyName} for {otherHobby.Stopwatch.Elapsed.TotalMinutes} minutes");
                                        break;
                                    case 5:
                                        track = true;
                                        break;
                                }
                             
                            }
                            break;
                    }
                }
                Console.ReadLine();
            }
           
            
        }
    }
}
