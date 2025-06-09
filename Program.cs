using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Как вас зовут?");
        string name = Console.ReadLine();
        Console.WriteLine($"Привет, {name}!");
        
        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}