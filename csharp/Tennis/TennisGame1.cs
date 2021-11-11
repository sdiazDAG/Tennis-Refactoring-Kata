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
            if (_mScore1 == _mScore2)
            {
                return HandleEqualScore();
            }
            else if (_mScore1 >= 4 || _mScore2 >= 4)
            {
                return HandleAdvantageOrWinScore();
            }
            return HandleGeneralScore(_mScore1) +  "-" + HandleGeneralScore(_mScore2);
        }

        private static string HandleGeneralScore(int tempScore) =>
            (tempScore) switch
            {
                0 => "Love",
                1 => "Fifteen",
                2 => "Thirty",
                3 => "Forty"
            };

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

