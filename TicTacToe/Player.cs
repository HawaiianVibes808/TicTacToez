using System.Net.NetworkInformation;

namespace TicTacToe
{
    public class Player
    {
        public string GameCharacter { get; set; }
        public int MovesPlayed { get; set; }

        public Player()
        {
            MovesPlayed = 0;
        }

        public Player(string gameCharacter)
        {
            GameCharacter = gameCharacter;
            MovesPlayed = 0;
        }
    } 
}