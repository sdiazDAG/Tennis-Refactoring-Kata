using System;

namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private int _p2;
        private int _p1;
        private readonly string _p1N;
        private readonly string _p2N;

        public TennisGame3(string player1Name, string player2Name)
        {
            _p1N = player1Name;
            _p2N = player2Name;
        }

        public string GetScore()
        {
            if (!CheckBeforeAnyPlayerTillForty())
            {
                string[] p = {"Love", "Fifteen", "Thirty", "Forty"};
                return (_p1.Equals(_p2)) ? p[_p1] + "-All" : p[_p1] + "-" + p[_p2];
            }

            if (GetDifference().Equals(0))
                return "Deuce";

            return GetDifference().Equals(1) 
                ? "Advantage " + GetWinningPlayerName() 
                : "Win for " + GetWinningPlayerName();
        }

        private string GetWinningPlayerName()
        {
            return _p1 > _p2 ? _p1N : _p2N;
        }

        private int GetDifference()
        {
            return Math.Abs(_p1 - _p2);
        }

        private bool CheckBeforeAnyPlayerTillForty()
        {
            return _p1 >= 4 || _p2 >= 4 || _p1 + _p2 >= 6;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                _p1 += 1;
            else
                _p2 += 1;
        }

    }
}

