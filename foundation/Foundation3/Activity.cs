using System;

namespace ExerciseTrackingProgram
{
    public class Activity
    {
        // Shared attributes
        private DateTime _date;
        private int _minutes;

        public Activity(DateTime date, int minutes)
        {
            _date = date;
            _minutes = minutes;
        }

        // Protected properties to allow derived classes to access them
        protected DateTime Date => _date;
        protected int Minutes => _minutes;

        public virtual double GetDistance()
        {
            return 0; // Default implementation
        }

        public virtual double GetSpeed()
        {
            return 0; // Default implementation
        }

        public virtual double GetPace()
        {
            double distance = GetDistance();
            return distance > 0 ? (double)Minutes / distance : 0; // Avoid division by zero
        }

        public virtual string GetSummary()
        {
            return $"{Date:dd MMM yyyy} Activity ({Minutes} min)";
        }
    }
}