using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Deck
{
    class Query
    {
        LoadCardData lcd = new LoadCardData();

        public List<GreenCards> getGreenCards()
        {
            List<GreenCards> greenCards = lcd.loadAllGreenCardsFromFile().ToList();
            return greenCards;
        }
        

        public List<GreenCards> getSpecificGreenCard(int greenCardID)
        {
            var greenCardDeck = getGreenCards();
            // Linq query that returns a list based on user input from the getVists list
            // user input includes start date, end date and location ID
            var greenCardSearchResult = from v in greenCardDeck
                                         where v.cardID == greenCardID                                   
                                         select v;
            return greenCardSearchResult.ToList();
        }

        public List<GreenCardResponses> getGreenCardResponses()
        {
            List<GreenCardResponses> greenCardResponses = lcd.loadAllGreenResponsesFromFile().ToList();
            return greenCardResponses;
        }

        public List<GreenCardResponses> getSpecificGreenCardResponse(int greenCardID)
        {
            var greenCardResponseDeck = getGreenCardResponses();
            // Linq query that returns a list based on user input from the getVists list
            // user input includes start date, end date and location ID
            var greenCardResponseSearchResult = from c in greenCardResponseDeck
                                                where c.responseID == greenCardID
                                                select c;
            return greenCardResponseSearchResult.ToList();
        }

        public List<RedCards> getRedCards()
        {
            List<RedCards> redCards = lcd.loadAllRedCardsFromFile().ToList();
            return redCards;
        }


    }

    
}
