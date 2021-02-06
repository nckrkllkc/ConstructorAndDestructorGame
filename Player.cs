using System;


namespace ConstructorAndDestructorGame
{
    public class Player : IDisposable
    {
        public static int PlayerCount;
        public string PlayerName { get; set; }
        public Player()
        {
            PlayerCount++;
            Console.WriteLine("A player joined the game :)");
        }
        static Player()
        {
            Player.PlayerCount = 0;
        }

        ~Player()
        {
            PlayerCount--;
        }

        public void Dispose()
        {
            Console.WriteLine("A player left the game :(");

        }
    }
}
