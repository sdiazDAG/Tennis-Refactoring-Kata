namespace Tennis
{
    public class GamePlayer3
    {
        private int _p1;
        private string _p1N;

        public GamePlayer3(string p1N)
        {
            _p1N = p1N;
        }

        public int P1
        {
            set { _p1 = value; }
            get { return _p1; }
        }

        public string P1N
        {
            set { _p1N = value; }
            get { return _p1N; }
        }
    }
}