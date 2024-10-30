namespace EternalQuestProgram  
{  
    public abstract class Goal  
    {  
        protected string _shortName;  
        protected string _description;  
        protected int _points;  

        public string Name => _shortName;  
        public int Points => _points;  

        protected Goal(string name, string description, int points)  
        {  
            _shortName = name;  
            _description = description;  
            _points = points;  
        }  

        // Method to allow derived classes to modify points  
        protected void AddPoints(int additionalPoints)  
        {  
            _points += additionalPoints;  
        }  

        public abstract void RecordEvent();  
        public abstract bool IsComplete();  
        public abstract string GetDetailsString();  
        public abstract string GetStringRepresentation();  
    }  
}