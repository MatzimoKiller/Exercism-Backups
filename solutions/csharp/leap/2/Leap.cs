using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
           if(year.IsDivisibleX(4) && !year.IsDivisibleX(100))
           return true;

           if(year.IsDivisibleX(4) && year.IsDivisibleX(100) && year.IsDivisibleX(400))
           return true;

           return false;
       
    }

    public static bool IsDivisibleX(this int num, int x) => num%x == 0;

}