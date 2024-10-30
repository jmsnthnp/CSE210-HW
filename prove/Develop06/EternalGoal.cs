namespace EternalQuestProgram  
{  
    public class EternalGoal : Goal  
    {  
        public EternalGoal(string name, string description, int points)   
            : base(name, description, points)  
        { }  

        public override void RecordEvent()  
        {  
            // No implementation needed for EternalGoals since they are always open-ended  
        }  

        public override bool IsComplete()  
        {  
            return false; // Never complete  
        }  

        public override string GetDetailsString()  
        {  
            return $"[ ] {_shortName} ({_description})"; // Always show as incomplete  
        }  

        public override string GetStringRepresentation()  
        {  
            return $"Eternal Goal,{_shortName},{_description},{_points}";  
        }  
    }  
}