using System;

public static class Bob
{
    public static bool IsUpper (this String str) =>  str == str.ToUpper() && (str.Contains('A') ||str.Contains('E') ||str.Contains('I') || str.Contains('O')||str.Contains('U')) ? true : false;
  
    public static string Response(string statement)
    {     
        string r = "Whatever.";
       if (String.IsNullOrWhiteSpace(statement)){
           r="Fine. Be that way!";
       }else if (statement.Trim().EndsWith('?') && statement.IsUpper()){
       r= "Calm down, I know what I'm doing!";
       }else if (statement.Trim().EndsWith('?')){
       r="Sure.";
       }else if (statement.IsUpper()){
       r="Whoa, chill out!";
       }

        return r;
    }
}