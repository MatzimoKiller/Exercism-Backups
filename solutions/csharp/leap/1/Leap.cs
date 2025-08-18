using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
       if(year.IsDivisible4() && !year.IsDivisible100())
       return true;

        if(year.IsDivisible4() && year.IsDivisible100() && year.IsDivisible400())
            return true;

        return false;
       
    }

    public static bool IsDivisible4(this int num) => num%4 == 0;
    public static bool IsDivisible400(this int num) => num%400 == 0;
    public static bool IsDivisible100(this int num) => num%100 == 0;
}