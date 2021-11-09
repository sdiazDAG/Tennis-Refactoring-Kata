namespace Tennis
{
    class GamePlayer1
    {
        private int m_score1 = 0;
        private string player1Name;

        public GamePlayer1(string player1Name)
        {
            this.player1Name = player1Name;
        }

        public int MScore1
        {
            set { m_score1 = value; }
            get { return m_score1; }
        }
    }
}