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

            // Instantiates the Random Number generator and sets the random number range to the number of cards in the deck
            RandomNumberGenerator rng = new RandomNumberGenerator(query.getGreenCards().Capacity);

            // Uses the random number generator and stroes it in an int variable 
            int randomNumber = rng.getRandomNumber;

            // Shows how many Cards are in the deck
            Console.WriteLine("Green Card is has " + query.getGreenCards().Capacity + " Cards in it");   

            // Writes the random number to the Console
            Console.WriteLine(randomNumber);

            // retrieves the correct set of answers for this green card         
            query.displaySpecificGreenCardAnswers(randomNumber);

            // retrieves the correct set of answers for this green card  
            query.displaySpecificGreenCardResponses(randomNumber, query.getUserCardAnswer());     
        }
    }          
}


