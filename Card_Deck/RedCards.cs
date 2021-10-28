using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Deck
{
    class RedCards : Cards
    {
        private string _cardColour;

        public RedCards(string cardColour, int cardID, string question, string answer1, string answer2, string answer3, string answer4) : base(cardID, question, answer1, answer2, answer3, answer4)
        {
            _cardColour = "Red";
        }

    }
}
