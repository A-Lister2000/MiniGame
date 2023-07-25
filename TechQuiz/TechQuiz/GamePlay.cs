using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechQuiz
{
    internal class GamePlay
    {

        private string OptionA;
        private string OptionB;
        private string OptionC;
        private string CorrectAnswer;
        private Image DisplayImage;

        public GamePlay()
        {

        }

        public void setOptionA(string _OptionA)
        {
            this.OptionA = _OptionA;
        }

        public string getAnswer()
        {
            return this.CorrectAnswer;
        }

        public void setOptionB(string _OptionB)
        {
            this.OptionB = _OptionB;
        }

        public void setOptionC(string _OptionC)
        {
            this.OptionC = _OptionC;
        }

        public void setGameAnswer (string _GameANswer) 
        {
            this.CorrectAnswer = _GameANswer;
        }

        public void setImage(Image _Image)
        {
            this.DisplayImage = _Image;
        }
    }
}
