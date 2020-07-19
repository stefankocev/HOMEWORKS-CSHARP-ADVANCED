﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.FinalHomework.Services.Helpers
{
    public static class ValidationHelper
    {
        public static int ValidateNumber(string number, int range)
        {
            int num = 0;
            bool isNumber = int.TryParse(number, out num);
            if (!isNumber)
            {
                return -1;
            }
            if (num <= 0 || num > range)
            {
                return -1;
            }
            return num;
        }
        public static string ValidateString(string str)
        {
            if (str.Length < 2)
            {
                return null;
            }
            foreach (var character in str.ToCharArray())
            {
                if (char.IsNumber(character))
                {
                    return null;
                }
            }
            return str;
        }

        public static string ValidateUsername(string username)
        {
            return username.Length < 5 ? null : username;
        }

        public static string ValidatePassword(string password)
        {
            if (password.Length < 6)
            {
                return null;
            }
            int number = 0;
            int upperLetter = 0;
            foreach (char character in password.ToCharArray())
            {
                if (char.IsNumber(character))
                {
                    number++;
                    
                }
                if (char.IsUpper(character))
                {
                    upperLetter++;
                    
                }
                if(number == 0 || upperLetter == 0)
                {
                    return password;
                }
            }
            return null;
        }
        public static int ValidateAge(string age)
        {
            int num = 0;
            bool isNumber = int.TryParse(age, out num);
            if (!isNumber)
            {
                return -1;
            }
            if (num < 18 || num > 120)
            {
                return 0;
            }
            return num;
        }

    }
}
    
