namespace Tennis
{
    class GamePlayer1
    {
        private int _score1 = 0;
        private string player1Name;

        public GamePlayer1(string player1Name)
        {
            this.player1Name = player1Name;
        }

        public int Score
        {
            set { _score1 = value; }
            get { return _score1; }
        }
    }
}