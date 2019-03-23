﻿using System;
namespace Zhenchak04
{
    static class BirthDataUtils
    {
        private const int MaxAge = 135;
        internal static bool IsBirthday(DateTime birthDate)
        {
            if (IsValidBirthDate(birthDate) == false)
            {
                throw new ArgumentException("not valid birthDate");
            }
            return DateTime.Today.DayOfYear == birthDate.DayOfYear;
        }

        internal static int CalculateAge(DateTime birthDate)
        {
            return DateTime.Today.Year - birthDate.Year;
        }

        internal static bool IsValidBirthDate(DateTime birthDate)
        {
            return IsValidAge(CalculateAge(birthDate));
        }

        static bool IsValidAge(int age)
        {
            return age >= 0 && age <= MaxAge;
        }
    }
}
