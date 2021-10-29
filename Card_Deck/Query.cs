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
            // Linq query that returns a list based on user input 
            var greenCardSearchResult = from v in greenCardDeck
                                        where v.cardID == greenCardID                                   
                                        select v;
            return greenCardSearchResult.ToList();
        }

        public int getUserCardAnswer()
        {            
            int answer;
            bool answerSuccess = int.TryParse(Console.ReadLine(), out answer);
            while (answerSuccess == false)
            {                
                // Asks the user to select an option between 1 and 4 and reads the input         
                if(answerSuccess)
                {
                    answerSuccess = true;                
                }

                else
                {
                    Console.WriteLine("TryParse fail : That is not a valid answer eco friend, please enter 1-4");
                    answerSuccess = int.TryParse(Console.ReadLine(), out answer);
                }
            }
            return answer;
        }
       

        public void displaySpecificGreenCardAnswers(int randomNumber)
        {
            // iterates through the list created by loading the CSV data - TODO - Must be a better way to do this
            foreach (GreenCards c in getSpecificGreenCard(randomNumber))
            {
                Console.WriteLine("Card ID : " + c.cardID + "\n" +
                                  "Question : " + c.question + "\n" +
                                  "answer1 : " + c.answer1 + "\n" +
                                  "answer2 : " + c.answer2 + "\n" +
                                  "answer3 : " + c.answer3 + "\n" +
                                  "answer4 : " + c.answer4 + "\n");
                Console.ReadLine();
            }

            Console.WriteLine("Select and answer between 1 and 4 and press enter");            
        }

        public void displaySpecificGreenCardResponses(int randomNumber, int answer)
        {

            bool validAnswer = false;

            foreach (GreenCardResponses r in getSpecificGreenCardResponse(randomNumber))
            {
                Console.WriteLine("Response ID : " + r.responseID + "\n" +
                                "Card Colour : " + r.cardColour + "\n" +
                                "response1 : " + r.response1 + "\n" +
                                "response2 : " + r.response2 + "\n" +
                                "response3 : " + r.response3 + "\n" +
                                "response4 : " + r.response4 + "\n");
                Console.ReadLine();

                while (validAnswer == false)
                {
                    switch (answer)
                    {
                        case 1:
                            Console.WriteLine("Response 1 : " + r.response1);
                            Console.ReadLine();
                            answer = 1;
                            validAnswer = true;
                            break;
                        case 2:
                            Console.WriteLine("Response 2 : " + r.response2);
                            Console.ReadLine();
                            answer = 2;
                            validAnswer = true;
                            break;
                        case 3:
                            Console.WriteLine("Response 3 : " + r.response3);
                            Console.ReadLine();
                            answer = 3;
                            validAnswer = true;
                            break;
                        case 4:
                            Console.WriteLine("Response 4 : " + r.response4);
                            Console.ReadLine();
                            answer = 4;
                            validAnswer = true;
                            break;
                        default:
                            Console.WriteLine("Default : That is not a valid answer eco friend, please enter 1-4");
                            answer = getUserCardAnswer();
                            validAnswer = false;
                            break;
                    }
                }
                // displays an message depending on the users input
            }
        }
        

        public List<GreenCardResponses> getGreenCardResponses()
        {
            List<GreenCardResponses> greenCardResponses = lcd.loadAllGreenResponsesFromFile().ToList();
            return greenCardResponses;
        }

        public List<GreenCardResponses> getSpecificGreenCardResponse(int greenCardID)
        {
            var greenCardResponseDeck = getGreenCardResponses();
            // Linq query that returns a list based on user input 
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
