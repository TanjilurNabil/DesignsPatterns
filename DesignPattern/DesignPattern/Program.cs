// See https://aka.ms/new-console-template for more information
using DesignPattern.Singletone;

Console.WriteLine("Hello, World!");

DateTimeProvider d = DateTimeProvider.Instance;
Console.WriteLine(d.GetCurrentDateTime());

Logger l1  = Logger.GetLogger();
l1.WriteLog("Hello, World!");