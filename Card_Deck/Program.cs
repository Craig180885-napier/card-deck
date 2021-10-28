using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Deck
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Query query = new Query();

            // Shows how many Cards are in the deck
            Console.WriteLine("Green Card is has " + query.getGreenCards().Capacity + " Cards in it");

            // Instantiaes the Random Number generator and sets the range to the number of cards in the deck
            RandomNumberGenerator rng = new RandomNumberGenerator(query.getGreenCards().Capacity);

            // Writes the random number to the Console
            Console.WriteLine(rng.getRandomNumber);

            // Creates a list to hold the green card with the ID that matches the random number that was generated
            List<GreenCards> specificGreenCard = query.getSpecificGreenCard(rng.getRandomNumber);


            // iterates through the list created by loading the CSV data - TODO - Must be a better way to do this
            foreach (GreenCards c in specificGreenCard)
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
                int answer = int.Parse(Console.ReadLine());

            List<GreenCardResponses> specificGreenCardResponse = query.getSpecificGreenCardResponse(rng.getRandomNumber);

            foreach (GreenCardResponses r in specificGreenCardResponse)
            {
                Console.WriteLine("Response ID : " + r.responseID + "\n" +
                                "Card Colour : " + r.cardColour + "\n" +
                                "response1 : " + r.response1 + "\n" +
                                "response2 : " + r.response2 + "\n" +
                                "response3 : " + r.response3 + "\n" +
                                "response4 : " + r.response4 + "\n");
                Console.ReadLine();

                switch (answer)
                {
                    case 1:
                        Console.WriteLine("Response 1 : " + r.response1);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Response 2 : " + r.response2);
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Response 3 : " + r.response3);
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Response 4 : " + r.response4);
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Default : That is not a valid answer eco friend, enter 1-4");
                        Console.ReadLine();
                        break;
                }
                // displays an message depending on the users input
         
                }
            }          
        }
    }

