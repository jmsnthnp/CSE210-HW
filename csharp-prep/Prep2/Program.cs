using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string response = Console.ReadLine();
        int percent = int.Parse(response);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int lastDigit = percent %10;
        string sign = "";

        if (lastDigit >=7)
        {
            sign = "+";
        }
        else if (lastDigit > 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        string gradeSign = letter + sign;

        if (gradeSign == "A+") 
        {
            gradeSign = "A";
        }
        if (gradeSign == "F+" || gradeSign == "F-") 
        {
            gradeSign = "F";
        }

        Console.WriteLine($"Your grade is {gradeSign}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed, congratulations!");
        }
        else
        {
            Console.WriteLine("You failed, you can do it next time!");
        }


    }
}