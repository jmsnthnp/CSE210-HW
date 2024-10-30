using System;

namespace ExerciseTrackingProgram
{
    public class Swimming : Activity
    {
        private int _laps;

        public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            return _laps * 50 / 1000; // Distance in kilometers
        }

        public override double GetSpeed()
        {
            return (GetDistance() / Minutes) * 60; // Speed in kph
        }

        public override string GetSummary()
        {
            return $"{Date:dd MMM yyyy} Swimming ({Minutes} min) - Distance {GetDistance():F1} km, Speed {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
        }
    }
}