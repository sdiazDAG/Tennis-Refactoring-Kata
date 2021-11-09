namespace Tennis
{
    class GamePlayer1
    {
        private int _score1 = 0;
        private string Name;

        public GamePlayer1(string name)
        {
            this.Name = name;
        }

        public int Score
        {
            set { _score1 = value; }
            get { return _score1; }
        }
    }
}