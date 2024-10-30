namespace EternalQuestProgram  
{  
    public class BadHabits : Goal  
    {  
        private int _penaltyPoints;  
        public int PenaltyPoints => _penaltyPoints; // Expose penalty points as a property

        public BadHabits(string name, string description, int penaltyPoints) : base(name, description, 0)  
        {  
            _penaltyPoints = penaltyPoints;  
        }  

        public override void RecordEvent()  
        {  
            // Logic to determine if the bad habit occurred (could be input from user)  
            AddPoints(-_penaltyPoints); // Deduct penalty points  
            Console.WriteLine($"Uh-oh! You lost {_penaltyPoints} points for this negative behavior.");  
        }  

        public override bool IsComplete()  
        {  
            return false; 
        }  

        public override string GetDetailsString() => $"{Name} (Penalty: {_penaltyPoints} points)";  
        
        public override string GetStringRepresentation()  
        {  
            return $"Bad Habit,{Name},{_description},{_penaltyPoints}";  
        }
    }  
}