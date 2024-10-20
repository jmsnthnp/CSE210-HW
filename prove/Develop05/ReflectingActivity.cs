using System;  
using System.Collections.Generic;  

namespace MindfulnessProgram  
{  
    public class ReflectingActivity : Activity  
    {  
        private List<string> _prompts = new List<string>  
        {  
            "Think of a time when you stood up for someone else.",  
            "Think of a time when you did something really difficult.",  
            "Think of a time when you helped someone in need.",  
            "Think of a time when you did something truly selfless."  
        };  

        private List<string> _questions = new List<string>  
        {  
            "Why was this experience meaningful to you?",  
            "Have you ever done anything like this before?",  
            "How did you get started?",  
            "How did you feel when it was complete?",  
            "What made this time different than other times when you were not as successful?",  
            "What is your favorite thing about this experience?",  
            "What could you learn from this experience that applies to other situations?",  
            "What did you learn about yourself through this experience?",  
            "How can you keep this experience in mind in the future?"  
        };  

        private HashSet<string> _usedPrompts = new HashSet<string>();  
        private HashSet<string> _usedQuestions = new HashSet<string>();  

        public ReflectingActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.")  
        {  
        }  

        public override void Run()  
        {  
            SetDuration();  
            DisplayStartingMessage();  

            string prompt = GetUniquePrompt();  
            Console.WriteLine(prompt);  
            ShowSpinner(5);  

            DateTime endTime = DateTime.Now.AddSeconds(_duration);  
            while (DateTime.Now < endTime)  
            {  
                string question = GetUniqueQuestion();  
                Console.WriteLine(question);  
                ReflectionSpinner(5);  
            }  

            IncrementActivityCount();  
            DisplayEndingMessage();  
        }  

        private string GetUniquePrompt()  
        {  
            if (_usedPrompts.Count == _prompts.Count)  
            {  
                _usedPrompts.Clear(); // Reset if all prompts have been used  
            }  

            Random random = new Random();  
            string prompt;  

            do  
            {  
                prompt = _prompts[random.Next(_prompts.Count)];  
            } while (_usedPrompts.Contains(prompt));  

            _usedPrompts.Add(prompt);  
            return prompt;  
        }  

        private string GetUniqueQuestion()  
        {  
            if (_usedQuestions.Count == _questions.Count)  
            {  
                _usedQuestions.Clear(); // Reset if all questions have been used  
            }  

            Random random = new Random();  
            string question;  

            do  
            {  
                question = _questions[random.Next(_questions.Count)];  
            } while (_usedQuestions.Contains(question));  

            _usedQuestions.Add(question);  
            return question;  
        }  
    }  
}