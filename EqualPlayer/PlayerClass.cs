namespace EqualPlayer
{
    public class PlayerClass
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is PlayerClass other)
                return Name == other.Name && Level == other.Level;

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Level);
        }

        public override string ToString()
        {
            return $"{Name} (Level {Level})";
        }
    }
}
