using System;

namespace LaunchBoxRemote.Plugin;

public static class Logger
{
    public static void Info(string message)=>Console.WriteLine($"[INFO] {message}");
    public static void Warning(string message)=>Console.WriteLine($"[WARN] {message}");
    public static void Error(string message)=>Console.WriteLine($"[ERROR] {message}");
    public static void Error(string message, Exception ex)=>Console.WriteLine($"[ERROR] {message}\n{ex}");
}
