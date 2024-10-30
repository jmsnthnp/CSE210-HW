using System;  
using System.Collections.Generic;  
using System.IO;  

namespace EternalQuestProgram  
{  
    public class GoalManager  
    {  
        private List<Goal> _goals;  
        private int _score;  

        public GoalManager()  
        {  
            _goals = new List<Goal>();  
            _score = 0;  
        }  

        public void Start()  
        {  
            while (true)  
            {  
                DisplayPlayerInfo();  
                Console.WriteLine("Menu Options");  
                Console.WriteLine("1. Create New Goal");  
                Console.WriteLine("2. List Goals");  
                Console.WriteLine("3. Save Goals");  
                Console.WriteLine("4. Load Goals");  
                Console.WriteLine("5. Record Event");  
                Console.WriteLine("6. Quit");  
                Console.Write("Select a choice from the menu: ");  
                var choice = Console.ReadLine();  

                switch (choice)  
                {  
                    case "1":  
                        CreateGoal();  
                        break;  
                    case "2":  
                        ListGoalDetails();  
                        break;  
                    case "3":  
                        SaveGoals();  
                        break;  
                    case "4":  
                        LoadGoals();  
                        break;  
                    case "5":  
                        RecordEvent();  
                        break;  
                    case "6":  
                        return;  
                    default:  
                        Console.WriteLine("Invalid choice. Please try again.");  
                        break;  
                }  
            }  
        }  

        private void DisplayPlayerInfo()  
        {  
            Console.WriteLine($"You have {_score} points.");  
        }  

        public void ListGoalDetails()  
        {  
            Console.WriteLine("The goals are:");  
            for (int i = 0; i < _goals.Count; i++)  
            {  
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");  
            }  
        }  

        public void CreateGoal()  
        {  
            Console.WriteLine("The types of Goals are:");  
            Console.WriteLine("1. Simple Goal");  
            Console.WriteLine("2. Eternal Goal");  
            Console.WriteLine("3. Checklist Goal");  
            Console.WriteLine("4. Bad Habits"); 
            Console.Write("Which type of goal would you like to create? (1/2/3/4): ");  
            var goalType = Console.ReadLine();  

            // Common prompts for all goals
            Console.Write("What is the name of your goal? ");  
            var name = Console.ReadLine();  
            Console.Write("What is a short description of it? ");  
            var description = Console.ReadLine();  

            switch (goalType)  
            {  
                case "1":  
                    Console.Write("What is the amount of points associated with this goal? ");  
                    var points = int.Parse(Console.ReadLine());  
                    _goals.Add(new SimpleGoal(name, description, points, false));
                    break;  
                case "2":  
                    Console.Write("What is the amount of points associated with this goal? ");  
                    points = int.Parse(Console.ReadLine());  
                    _goals.Add(new EternalGoal(name, description, points));  
                    break;  
                case "3":  
                    Console.Write("What is the amount of points associated with this goal? ");  
                    points = int.Parse(Console.ReadLine());  
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");  
                    var target = int.Parse(Console.ReadLine());  
                    Console.Write("What is the bonus for accomplishing it that many times? ");  
                    var bonus = int.Parse(Console.ReadLine());  
                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus, 0));
                    break;  
                case "4": // New case for Negative Goal
                    Console.Write("What is the penalty for this bad habit? ");  
                    var penaltyPoints = int.Parse(Console.ReadLine());  
                    _goals.Add(new BadHabits(name, description, penaltyPoints));  
                    break;      
                default:  
                    Console.WriteLine("Invalid goal type.");  
                    break;  
            }  
        }

        public void RecordEvent()  
        {  
            ListGoalNames();  
            Console.Write("Which goal did you accomplish? ");  
            var choice = int.Parse(Console.ReadLine()) - 1;  
            if (choice >= 0 && choice < _goals.Count)  
            {  
                _goals[choice].RecordEvent();  
                if (_goals[choice] is BadHabits)  
                {
                    _score -= ((BadHabits)_goals[choice]).PenaltyPoints; // Deduct penalty points from the score
                }
                else
                {
                    _score += _goals[choice].Points; // Add Points   
                    Console.WriteLine($"Congratulations! You have earned {_goals[choice].Points} points! You now have {_score} points."); 
                } 
            }  
            else  
            {  
                Console.WriteLine("Invalid choice.");  
            }  
        }  

        public void ListGoalNames()  
        {  
            Console.WriteLine("The goals are:");  
            for (int i = 0; i < _goals.Count; i++)  
            {  
                Console.WriteLine($"{i + 1}. {_goals[i].Name}");  
            }  
        }  

        public void SaveGoals()  
        {  
            Console.Write("Enter the file name to save goals: ");  
            var filename = Console.ReadLine();  

            using (var writer = new StreamWriter(filename))  
            {  
                writer.WriteLine(_score);  
                foreach (var goal in _goals)  
                {  
                    writer.WriteLine(goal.GetStringRepresentation());  
                }  
            }  
            Console.WriteLine("Goals saved successfully.");  
        }  

        public void LoadGoals()  
        {  
            Console.Write("Enter the file name to load goals: ");  
            var filename = Console.ReadLine();  

            if (File.Exists(filename))  
            {  
                using (var reader = new StreamReader(filename))  
                {  
                    _score = int.Parse(reader.ReadLine());  
                    _goals.Clear();  
                    string line;  
                    while ((line = reader.ReadLine()) != null)  
                    {  
                        var parts = line.Split(',');  
                        var type = parts[0];  

                        switch (type)  
                        {  
                            case "Simple Goal":  
                                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));  
                                break;  
                            case "Eternal Goal":  
                                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));  
                                break;  
                            case "Checklist Goal":  
                                _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));  
                                break;  
                            case "Bad Habit":  
                                _goals.Add(new BadHabits(parts[1], parts[2], int.Parse(parts[3])));  
                                break;  
                        }  
                    }  
                }  
                Console.WriteLine("Goals loaded successfully.");  
            }  
            else  
            {  
                Console.WriteLine("File not found.");  
            }  
        }  
    }  
}