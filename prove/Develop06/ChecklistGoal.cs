namespace EternalQuestProgram  
{  
    public class ChecklistGoal : Goal  
    {  
        private int _amountCompleted;  
        private int _target;  
        private int _bonus;  

        // Updated constructor  
        public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted)   
            : base(name, description, points)  
        {  
            _amountCompleted = amountCompleted; // Use the provided amount complete  
            _target = target;  
            _bonus = bonus;  
        }  

        public override void RecordEvent()  
        {  
            if (_amountCompleted < _target)  
            {  
                _amountCompleted++;  
                // Check for completion and apply bonus if necessary  
                if (_amountCompleted == _target)  
                {  
                    // Add bonus points  
                    AddPoints(_bonus); // Use AddPoints to increase total Points   
                    Console.WriteLine($"Congratulations! You have completed the goal and earned a bonus of {_bonus} points!");  
                }  
            }  
        }  

        public override bool IsComplete()  
        {  
            return _amountCompleted >= _target;  
            
        }  

        public override string GetDetailsString()  
        {  
            return $"{(_amountCompleted >= _target ? "[X]" : "[ ]")} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";  
        }  

        public override string GetStringRepresentation()  
        {  
            return $"Checklist Goal,{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";  
        }  
    }  
}