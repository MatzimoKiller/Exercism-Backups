using System;

static class LogLine
{
    public static string Message(string logLine)
    {    
        int inicio= logLine.IndexOf(":") + 1;
        return logLine.Substring(inicio).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int fin= logLine.IndexOf("]") - 1;
        return logLine.Substring(1,fin).ToLower();
    }

    public static string Reformat(string logLine)
    {
        string message= LogLine.Message(logLine);
        string level= LogLine.LogLevel(logLine);
        return ($"{message} ({level})") ;
    }
}
