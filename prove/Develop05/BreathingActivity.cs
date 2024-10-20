using System;  
using System.Threading;

namespace MindfulnessProgram  
{  
    public class BreathingActivity : Activity  
    {  
        public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")  
        {  
        }  

        public override void Run()  
        {  
            SetDuration();  
            DisplayStartingMessage();  

            DateTime endTime = DateTime.Now.AddSeconds(_duration);  
            while (DateTime.Now < endTime)  
            {  
                Console.WriteLine("Breathe in...");  
                ShowBreathingAnimation(5, "in");  
                Console.WriteLine("Breathe out...");  
                ShowBreathingAnimation(5, "out");  
            }  

            IncrementActivityCount();  
            DisplayEndingMessage();  
        }  

        private void ShowBreathingAnimation(int seconds, string direction)  
        {  
            string[] spinner = { "|", "/", "-", "\\" };  

            for (int i = 0; i < seconds; i++)  
            {  
                for (int j = 0; j < spinner.Length; j++)  
                {  
                    Console.Write($"\r{spinner[j]} Breathe {direction}... ({seconds - i} seconds left)");  
                    Thread.Sleep(250);  
                }  
            }  
            Console.WriteLine();  
        }  
    }  
}
