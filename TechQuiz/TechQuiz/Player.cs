using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechQuiz
{
    internal class Player
    {
        private string Answer;
        private int Score = 0;
        private double Credit = 5000.00;

        public Player()
        {

        }

        public void setAnswer(string _Answer)
        {
            this.Answer = _Answer;
        }

        public string getAnswer()
        {
            return this.Answer;
        }

        public void setScore(int _Score)
        {
            this.Score = _Score;
        }

        public int getScore()
        {
            return this.Score;
        }

        public double getCredit()
        {
            return this.Credit;
        }
    }
}
