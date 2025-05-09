namespace EqualPlayer
{
    public class Player
    {
        public string Username { get; set; }
        public PlayerClass PlayerClass { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is Player other)
                return Username == other.Username &&
                       PlayerClass.Equals(other.PlayerClass);

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Username, PlayerClass);
        }

        public override string ToString()
        {
            return $"{Username} - {PlayerClass}";
        }
    }
}
