using System;

namespace ArcadeLog
{
    public class Score : IComparable<Score>
    {
        private int points;

        public string Name { get; }


        public int Points
        {
            get { return points; }

            set
            {
                if (value < 0)
                    points = 0;
                else if (value > 9999)
                    points = 9999;
                else
                    points = value;
            }
        }

        // Medalha
        public string Medal
        {
            get
            {
                if (Points >= 7000)
                    return "Gold";
                else if (Points >= 4000)
                    return "Silver";
                else
                    return "Bronze";
            }
        }

        public Score(string name, int points)
        {
            Name = name;
            Points = points;
        }

        public int CompareTo(Score other)
        {
            return other.Points.CompareTo(Points);
        }

        public override string ToString()
        {
            return $"{Name} [{Medal}]: {Points}";
        }
    }
}