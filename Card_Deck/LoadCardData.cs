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
       public List<Cards> loadAllGreenCardsFromFile()
        {
            List<Cards> greenCards = new List<Cards>();

            using (var reader = new StreamReader("C:\\Users\\Craig\\Documents\\csv\\GreenCards.csv"))
            {
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    int cardID = int.Parse(values[0]);
                    string question = values[1];
                    string answer1 = values[2];
                    string answer2 = values[3];
                    string answer3 = values[4];
                    string answer4 = values[5];

                    greenCards.Add(new Cards(cardID, question, answer1, answer2, answer3, answer4));
                }
            }
            return greenCards;
        }
    }

}
