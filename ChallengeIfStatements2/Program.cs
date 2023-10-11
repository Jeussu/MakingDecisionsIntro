namespace ChallengeIfStatements2
{
    internal class Program
    {
        static int highscore = 300;
        static string highscorePlayer = "Vinh";
        static void Main(string[] args)
        {
            // Initialize the score and playerName locally for testing purpose

            CheckAndUpdateHighScore(250, "Thanh");
            CheckAndUpdateHighScore(315, "Hanh");
            CheckAndUpdateHighScore(350, "Tuan");

            Console.Read();
        }

        public static void CheckAndUpdateHighScore(int score, string playerName)
        {
            //check if the current score is higher than the existing hightscore
            if (score > highscore)
            {
                // If yes, update the hightscore and hightscorePlayer
                highscore = score;
                highscorePlayer = playerName;

                Console.WriteLine("New highscore is: " + score);
                Console.WriteLine("New highscore holder is: " + playerName);
            }
            else
                Console.WriteLine("The old hightscore could not be broken. It is still "
                    + highscore + " and held by " + highscorePlayer);
        }
    }
}