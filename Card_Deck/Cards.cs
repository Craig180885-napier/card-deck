using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Deck
{
    class Cards
    {       
        private int _cardID;
        private string _question;
        private string _answer1;
        private string _answer2;
        private string _answer3;
        private string _answer4;

        public int cardID
        {
            get
            {
                return _cardID;
            }

            set
            {
                _cardID = value;
            }
        }
        public string question { get { return _question; } }
        public string answer1 { get { return _answer1; } }
        public string answer2 { get { return _answer2; } }
        public string answer3 { get { return _answer3; } }
        public string answer4 { get { return _answer4; } }

        public Cards(int cardID, string question, string answer1, string answer2, string answer3, string answer4)
        {
            _cardID = cardID;
            _question = question;
            _answer1 = answer1;
            _answer2 = answer2;
            _answer3 = answer3;
            _answer4 = answer4;
        }

    

    }
}
