using System;

namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private readonly GamePlayer3 _gamePlayer1;
        private readonly GamePlayer3 _gamePlayer2;

        public TennisGame3(string player1Name, string player2Name)
        {
            _gamePlayer1 = new GamePlayer3(player1Name);
            _gamePlayer2 = new GamePlayer3(player2Name); ;
        }

        public string GetScore()
        {
            if (!CheckBeforeAnyPlayerTillForty())
            {
                string[] p = {"Love", "Fifteen", "Thirty", "Forty"};
                return (_gamePlayer1.PlayerNumber.Equals(_gamePlayer2.PlayerNumber)) ? p[_gamePlayer1.PlayerNumber] + "-All" : p[_gamePlayer1.PlayerNumber] + "-" + p[_gamePlayer2.PlayerNumber];
            }

            if (GetDifference().Equals(0))
                return "Deuce";

            return GetDifference().Equals(1) 
                ? "Advantage " + GetWinningPlayerName() 
                : "Win for " + GetWinningPlayerName();
        }

        private string GetWinningPlayerName()
        {
            return _gamePlayer1.PlayerNumber > _gamePlayer2.PlayerNumber ? _gamePlayer1.PlayerName : _gamePlayer2.PlayerName;
        }

        private int GetDifference()
        {
            return Math.Abs(_gamePlayer1.PlayerNumber - _gamePlayer2.PlayerNumber);
        }

        private bool CheckBeforeAnyPlayerTillForty()
        {
            return _gamePlayer1.PlayerNumber >= 4 || _gamePlayer2.PlayerNumber >= 4 || _gamePlayer1.PlayerNumber + _gamePlayer2.PlayerNumber >= 6;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                _gamePlayer1.PlayerNumber += 1;
            else
                _gamePlayer2.PlayerNumber += 1;
        }

    }
}

