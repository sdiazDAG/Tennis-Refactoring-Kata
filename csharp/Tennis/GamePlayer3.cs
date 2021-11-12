namespace Tennis
{
    public class GamePlayer3
    {
        public GamePlayer3(string playerName)
        {
            PlayerName = playerName;
        }

        public int PlayerScore { set; get; }

        public string PlayerName { set; get; }
    }
}