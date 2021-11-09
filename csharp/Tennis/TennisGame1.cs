namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private readonly GamePlayer1 _gamePlayer2;
        private readonly GamePlayer1 _gamePlayer1;

        public TennisGame1(string player1Name, string player2Name)
        {
            _gamePlayer1 = new GamePlayer1(player1Name);
            _gamePlayer2 = new GamePlayer1(player2Name);
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                _gamePlayer1.Score += 1;
            else
                _gamePlayer2.Score += 1;
        }

        public string GetScore()
        {
            string score = "";
            var tempScore = 0;
            if (_gamePlayer1.Score == _gamePlayer2.Score)
            {
                switch (_gamePlayer1.Score)
                {
                    case 0:
                        score = "Love-All";
                        break;
                    case 1:
                        score = "Fifteen-All";
                        break;
                    case 2:
                        score = "Thirty-All";
                        break;
                    default:
                        score = "Deuce";
                        break;

                }
            }
            else if (_gamePlayer1.Score >= 4 || _gamePlayer2.Score >= 4)
            {
                var minusResult = _gamePlayer1.Score - _gamePlayer2.Score;
                if (minusResult == 1) score = "Advantage player1";
                else if (minusResult == -1) score = "Advantage player2";
                else if (minusResult >= 2) score = "Win for player1";
                else score = "Win for player2";
            }
            else
            {
                for (var i = 1; i < 3; i++)
                {
                    if (i == 1) tempScore = _gamePlayer1.Score;
                    else { score += "-"; tempScore = _gamePlayer2.Score; }
                    switch (tempScore)
                    {
                        case 0:
                            score += "Love";
                            break;
                        case 1:
                            score += "Fifteen";
                            break;
                        case 2:
                            score += "Thirty";
                            break;
                        case 3:
                            score += "Forty";
                            break;
                    }
                }
            }
            return score;
        }
    }
}

