using System;

public static class RomanNumeralExtension
{

     public static string UnitToRoman(int value)
    {
    return value switch{
            1 => "I",
            2 => "II",
            3 => "III",
            4 => "IV",
            5 => "V",
            6 => "VI",
            7 => "VII",
            8 => "VIII",
            9 => "IX",
            0 => "",
    };
    }

     public static string TenToRoman(int value){
    return value switch{
            1 => "X",
            2 => "XX",
            3 => "XXX",
            4 => "XL",
            5 => "L",
            6 => "LX",
            7 => "LXX",
            8 => "LXXX",
            9 => "XC",
            0 => "",
     };
    }

      public static string HundredToRoman(int value){
    return value switch{
            1 => "C",
            2 => "CC",
            3 => "CCC",
            4 => "CD",
            5 => "D",
            6 => "DC",
            7 => "DCC",
            8 => "DCCC",
            9 => "CM",
            0 => "",
     };
    }

     public static string ThousandToRoman(int value){
    return value switch{
            1 => "M",
            2 => "MM",
            3 => "MMM",
     };
     }

    public static string ToRoman(this int value) =>
        value switch{
            >= 1000 => ThousandToRoman(value/1000) + HundredToRoman(value%1000/100) + TenToRoman(value%100/10) + UnitToRoman(value%10),

            >=100 => HundredToRoman(value%1000/100) + TenToRoman(value%100/10) + UnitToRoman(value%10),

            >= 10 => TenToRoman(value%100/10) + UnitToRoman(value%10),

            _ => UnitToRoman(value%10),
        };
}