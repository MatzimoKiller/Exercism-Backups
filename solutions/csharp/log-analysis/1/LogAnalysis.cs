using System;

public static class LogAnalysis 
{
    public static String SubstringAfter(this String log, String delimiter){
       return log.Substring(log.IndexOf(delimiter) + delimiter.Length);
    }
 
     public static String SubstringBetween(this String log, String delimiteri, String delimiterf){
       return log.Substring(log.IndexOf(delimiteri) + delimiteri.Length, log.IndexOf(delimiterf) - (log.IndexOf(delimiteri) + delimiteri.Length));
    }

    public static String Message(this String log){
        return log.SubstringAfter(": ");
    }

    public static String LogLevel(this String log){
        return log.SubstringBetween("[","]");
    }
}