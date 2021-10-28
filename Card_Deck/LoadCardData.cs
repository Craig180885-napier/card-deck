using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Deck
{
    class LoadCardData
    {
        
    public string usersPath = "C:\\Users\\Craig\\Documents\\csv\\GreenCards.csv";

      // Loads Green Cards from the CSV file
       public List<GreenCards> loadAllGreenCardsFromFile()
        {
            List<GreenCards> greenCards = new List<GreenCards>();

            using (var reader = new StreamReader("C:\\Users\\Craig\\Documents\\csv\\GreenCards.csv")) // TODO - Move this to within the solution
            {
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    string cardColour = "Green";
                    int cardID = int.Parse(values[0]);
                    string question = values[1];
                    string answer1 = values[2];
                    string answer2 = values[3];
                    string answer3 = values[4];
                    string answer4 = values[5];

                    greenCards.Add(new GreenCards(cardColour, cardID, question, answer1, answer2, answer3, answer4));                    
                }
            }
            return greenCards;
        }

        public List<GreenCardResponses> loadAllGreenResponsesFromFile()
        {
            List<GreenCardResponses> greenCardResponses = new List<GreenCardResponses>();

            using (var reader = new StreamReader("C:\\Users\\Craig\\Documents\\csv\\GreenCardResponses.csv")) // TODO - Move this to within the solution
            {
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    string cardColour = "Green";
                    int responseID = int.Parse(values[0]);                 
                    string response1 = values[1];
                    string response2 = values[2];
                    string response3 = values[3];
                    string response4 = values[4];

                    greenCardResponses.Add(new GreenCardResponses(cardColour, responseID, response1, response2, response3, response4));
                }
            }
            return greenCardResponses;
        }


        // Loads Red Cards from the CSV file
        public List<RedCards> loadAllRedCardsFromFile()
        {
            List<RedCards> redCards = new List<RedCards>();

            using (var reader = new StreamReader("C:\\Users\\Craig\\Documents\\csv\\RedCards.csv"))  // TODO - Move this to within the solution
            {
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    string cardColour = "Red";
                    int cardID = int.Parse(values[0]);
                    string question = values[1];
                    string answer1 = values[2];
                    string answer2 = values[3];
                    string answer3 = values[4];
                    string answer4 = values[5];

                    redCards.Add(new RedCards(cardColour, cardID, question, answer1, answer2, answer3, answer4));
                    // ID.Instance.nextCardID();
                }
            }
            return redCards;
        }
    }

}
