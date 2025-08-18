using System;

public static class LogAnalysis 
{
    public static String SubstringAfter(this String log, String delimiter) => log.Substring(log.IndexOf(delimiter) + delimiter.Length);
    
 
     public static String SubstringBetween(this String log, String delimiteri, String delimiterf){
    int inicio = log.IndexOf(delimiteri) + delimiteri.Length;
    int final = log.IndexOf(delimiterf);
    return log.Substring(inicio, final - inicio);
    }

    public static String Message(this String log){
        return log.SubstringAfter(": ");
    }

    public static String LogLevel(this String log){
        return log.SubstringBetween("[","]");
    }
}