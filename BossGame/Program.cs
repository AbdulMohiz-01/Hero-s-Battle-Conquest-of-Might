namespace BossGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game();
            while ((!myGame.Win()) && (!myGame.Lose()))
            {
                myGame.PlayRound();
                Console.WriteLine(); //Change this to a printline in your language.
            }
        }
    }
}