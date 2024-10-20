using System;  

namespace MindfulnessProgram  
{  
    public abstract class Activity  
    {  
        protected int _duration;  
        protected int _activityCount;  

        public Activity(string name, string description)  
        {  
            Name = name;  
            Description = description;  
            _activityCount = 0;  
        }  

        public string Name { get; }  
        public string Description { get; }  

        public void SetDuration()  
        {  
            Console.Write("Enter the duration in seconds: ");  
            _duration = int.Parse(Console.ReadLine());  
        }  

        public void IncrementActivityCount()  
        {  
            _activityCount++;  
        }  

        public int GetActivityCount()  
        {  
            return _activityCount;  
        }  

        public abstract void Run();  

        protected void DisplayStartingMessage()  
        {  
            Console.WriteLine($"Starting {Name}: {Description}");  
            Console.WriteLine("Get ready...");  
            ShowSpinner(3);  
        }  

        protected void DisplayEndingMessage()  
        {  
            Console.WriteLine("Good job! You've completed the activity.");  
            Console.WriteLine($"You spent { _duration } seconds on this activity.");  
            ShowSpinner(3);  
        }  

        protected void ShowSpinner(int seconds)  
        {  
            for (int i = 0; i < seconds; i++)  
            {  
                Console.Write(".");  
                System.Threading.Thread.Sleep(1000);  
            }  
            Console.WriteLine();  
        }  

       protected void ReflectionSpinner(int seconds)  
        {  
            for (int i = 0; i < seconds; i++)  
            {  
                Console.Write("/"); Thread.Sleep(250);  
                Console.Write("\b \b");  
                Console.Write("-"); Thread.Sleep(250);  
                Console.Write("\b \b");  
                Console.Write("\\"); Thread.Sleep(250);  
                Console.Write("\b \b");  
                Console.Write("|"); Thread.Sleep(250);  
                Console.Write("\b \b");  
            }  
        }
    }  
}