using System;

static class Badge
{
    public static string Print(int? id, string name, string? department) => id.HasValue ? 
     $"[{id}] - {name} - {(department ?? "owner").ToUpper()}":
     $"{name} - {(department ?? "owner").ToUpper()}";

}
