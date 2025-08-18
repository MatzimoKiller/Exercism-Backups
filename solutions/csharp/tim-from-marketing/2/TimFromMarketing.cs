using System;

static class Badge
{
    public static string Print(int? id, string name, string? department) => id == null ? 
        $"{name} - {(department ?? "owner").ToUpper()}" : 
        $"[{id}] - {name} - {(department ?? "owner").ToUpper()}";

}
