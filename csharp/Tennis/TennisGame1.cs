namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private int _mScore1 = 0;
        private int _mScore2 = 0;

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                _mScore1 += 1;
            else
                _mScore2 += 1;
        }

        public string GetScore()
        {
            string score = "";
            var tempScore = 0;
            if (_mScore1 == _mScore2)
            {
                score = HandleEqualScore();
            }
            else if (_mScore1 >= 4 || _mScore2 >= 4)
            {
                score = HandleAdvantageOrWinScore();
            }
            else
            {
                for (var i = 1; i < 3; i++)
                {
                    if (i == 1) tempScore = _mScore1;
                    else { score += "-"; tempScore = _mScore2; }

                    score = HandleGeneralScore(tempScore, score);
                }
            }
            return score;
        }

        private static string HandleGeneralScore(int tempScore, string score)
        {
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

            return score;
        }

        private string HandleAdvantageOrWinScore() =>
            (_mScore1 - _mScore2) switch
            {
                1 => "Advantage player1",
                -1 => "Advantage player2",
                >= 2 => "Win for player1",
                _ => "Win for player2"
            };

        private string HandleEqualScore() =>
            _mScore1 switch
            {
                0 => "Love-All",
                1 => "Fifteen-All",
                2 => "Thirty-All",
                _ => "Deuce"
            };
    }
}

