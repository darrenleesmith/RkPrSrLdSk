using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Score
    {
        public int UserAttempt = 0;

        private int _scoreWin;
        private int _scoreDraw;
        private int _scoreLose;
        private int _scoreTotal;

        public Score (int scoreWin, int scoreDraw, int scoreLose, int scoreTotal)
        {
            _scoreWin = scoreWin;
            _scoreDraw = scoreDraw;
            _scoreLose = scoreLose;
            _scoreTotal = scoreTotal;
        }

        public Score()
        {
            _scoreWin = 0;
            _scoreDraw = 0;
            _scoreLose = 0;
            _scoreTotal = 0;
        }

        public int ScoreWin
        {
            set
            {
                _scoreWin = value;
            }
            get
            {
                return _scoreWin;
            }
        }
        public int addWin()
        {
            return _scoreWin + 1;
        }
        public int ScoreDraw
        {
            set
            {
                _scoreDraw = value;
            }
            get
            {
                return _scoreDraw;
            }
        }
        public int ScoreLose
        {
            set
            {
                _scoreLose = value;
            }
            get
            {
                return _scoreLose;
            }
        }
        public int ScoreTotal
        {
            set
            {
                _scoreTotal = value;
            }
            get
            {
                return _scoreTotal;
            }
        }
    }
}
