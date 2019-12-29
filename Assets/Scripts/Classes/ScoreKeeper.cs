namespace Classes
{
    public static class ScoreKeeper
    {
        private static string leadZeroFmt = "0000000";
        
        private static int playerScore = 0;

        public static void ResetScore()
        {
            playerScore = 0;
        }

        public static void SetScore(int score)
        {
            playerScore = score;
        }

        public static void IncrementScore(int value)
        {
            playerScore += value;
        }

        public static void DecrementScore(int value)
        {
            playerScore -= value;
        }

        public static string GetScoreAsString()
        {
            return playerScore.ToString(leadZeroFmt);
        }

        public static int GetScore()
        {
            return playerScore;
        }
    }
    
    
}