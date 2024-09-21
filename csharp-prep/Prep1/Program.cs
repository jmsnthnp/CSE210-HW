using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string f_name = Console.ReadLine();
        
        Console.WriteLine("What is your last name?");
        string l_name = Console.ReadLine();

        Console.WriteLine($"Your name is {l_name}, {f_name} {l_name}.");
    }
}