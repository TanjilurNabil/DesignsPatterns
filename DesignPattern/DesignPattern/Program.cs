// See https://aka.ms/new-console-template for more information
using DesignPattern.Singletone;

Console.WriteLine("Hello, World!");

DateTimeProvider d = DateTimeProvider.Instance;
Console.WriteLine(d.GetCurrentDateTime());

