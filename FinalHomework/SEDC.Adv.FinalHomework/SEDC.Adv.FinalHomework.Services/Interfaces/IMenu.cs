using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.FinalHomework.Services.Interfaces
{
    public interface IMenu
    {
        int MenuChoiceValidation(int range);
        int StartMenu();
        int MainMenu();
        int TrackMenu();
        int ReadingMenu();
        int ExercisingMenu();
        int WorkingMenu();
        int AccountManagementMenu();
        int StatisticsMenu();
    }
}
