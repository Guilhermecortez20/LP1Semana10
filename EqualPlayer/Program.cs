using System;

namespace EqualPlayer
{
    class Program
    {
        static void Main()
        {
            var mage = new PlayerClass { Name = "Mage", Level = 5 };
            var warrior = new PlayerClass { Name = "Warrior", Level = 7 };

            var player1 = new Player { Username = "Alice", PlayerClass = mage };
            var player2 = new Player { Username = "Alice", PlayerClass = new PlayerClass { Name = "Mage", Level = 5 } };
            var player3 = new Player { Username = "Bob", PlayerClass = warrior };

            Console.WriteLine(player1.Equals(player2)); // True
            Console.WriteLine(player1.Equals(player3)); // False
        }
    }
}

