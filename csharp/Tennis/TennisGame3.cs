using System;

namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private int _p2;
        private readonly string _p2N;
        private readonly GamePlayer3 _gamePlayer3;

        public TennisGame3(string player1Name, string player2Name)
        {
            _gamePlayer3 = new GamePlayer3(player1Name);
            _p2N = player2Name;
        }

        public string GetScore()
        {
            if (!CheckBeforeAnyPlayerTillForty())
            {
                string[] p = {"Love", "Fifteen", "Thirty", "Forty"};
                return (_gamePlayer3.P1.Equals(_p2)) ? p[_gamePlayer3.P1] + "-All" : p[_gamePlayer3.P1] + "-" + p[_p2];
            }

            if (GetDifference().Equals(0))
                return "Deuce";

            return GetDifference().Equals(1) 
                ? "Advantage " + GetWinningPlayerName() 
                : "Win for " + GetWinningPlayerName();
        }

        private string GetWinningPlayerName()
        {
            return _gamePlayer3.P1 > _p2 ? _gamePlayer3.P1N : _p2N;
        }

        private int GetDifference()
        {
            return Math.Abs(_gamePlayer3.P1 - _p2);
        }

        private bool CheckBeforeAnyPlayerTillForty()
        {
            return _gamePlayer3.P1 >= 4 || _p2 >= 4 || _gamePlayer3.P1 + _p2 >= 6;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                _gamePlayer3.P1 += 1;
            else
                _p2 += 1;
        }

    }
}

