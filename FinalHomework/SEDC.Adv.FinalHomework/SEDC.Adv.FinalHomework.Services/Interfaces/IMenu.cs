using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.FinalHomework.Services.Interfaces
{
    public interface IMenu
    {
        int MenuChoiceValidation(int range);
        int StartMenu();
        void MainMenu();
        void TrackMenu();
        void ReadingMenu();
        void ExercisingMenu();
        void WorkingMenu();
        void AccountManagementMenu();
        void StatisticsMenu();
    }
}
