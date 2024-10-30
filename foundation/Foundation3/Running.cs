using System;

namespace ExerciseTrackingProgram
{
    public class Running : Activity
    {
        private double _distance; // in miles

        public Running(DateTime date, int minutes, double distance) : base(date, minutes)
        {
            _distance = distance;
        }

        public override double GetDistance()
        {
            return _distance;
        }

        public override double GetSpeed()
        {
            return (GetDistance() / Minutes) * 60; // Speed in mph
        }

        public override string GetSummary()
        {
            return $"{Date:dd MMM yyyy} Running ({Minutes} min) - Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
        }
    }
}