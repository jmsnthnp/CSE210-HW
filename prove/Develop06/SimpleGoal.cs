namespace EternalQuestProgram  
{  
    public class SimpleGoal : Goal  
    {  
        private bool _isComplete;  

        public SimpleGoal(string name, string description, int points, bool isComplete)   
            : base(name, description, points)  
        {  
            _isComplete = isComplete;  
        }  

        public override void RecordEvent()  
        {  
            _isComplete = true;  
        }  

        public override bool IsComplete()  
        {  
            return _isComplete;  
        }  

        public override string GetDetailsString()  
        {  
            return $"{(_isComplete ? "[X]" : "[ ]")} {_shortName} ({_description})";  
        }  

        public override string GetStringRepresentation()  
        {  
            return $"Simple Goal,{_shortName},{_description},{_points},{_isComplete}";  
        }  
    }  
}