using System;

namespace ExerciseTrackingProgram
{
    public class Cycling : Activity
    {
        private double _speed; // in mph

        public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
        {
            _speed = speed;
        }

        public override double GetDistance()
        {
            return (GetSpeed() / 60) * Minutes; // Distance = Speed * Time
        }

        public override double GetSpeed()
        {
            return _speed;
        }

        public override string GetSummary()
        {
            return $"{Date:dd MMM yyyy} Cycling ({Minutes} min) - Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
        }
    }
}