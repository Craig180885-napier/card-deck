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

            RandomNumberGenerator rng = new RandomNumberGenerator(100);
            LoadCardData lcd = new LoadCardData();

            // iterates through the list created by loading the CSV data 
            foreach(Cards c in lcd.loadAllGreenCardsFromFile().ToList())
            {
                
                Console.WriteLine("Card ID : "  + c.cardID + "\n" + 
                                  "Question : " + c.question + "\n" +
                                  "answer1 : " + c.answer1 + "\n" +
                                  "answer2 : " + c.answer2 + "\n" +
                                  "answer3 : " + c.answer3 + "\n" +
                                  "answer4 : " + c.answer4 + "\n");
                Console.ReadLine();
                Console.WriteLine("Select and answer between 1 and 4 and press enter");
                int answer = int.Parse(Console.ReadLine());

                // displays an message depending on the users input
                switch (answer)
                { 
                    case 1:
                        Console.WriteLine("Case 1 : No points for you lazy pants");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Case 2 : 5 moneyz, please use it to buy more underwear");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Case 3 : 20 moneyz, you are at least doing something");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Case 4 : 40 moneyz, if there were more like you we wouldn't be in this mess xoxo");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Default : That is not a valid answer eco friend, enter 1-4");
                        Console.ReadLine();
                        break;
                }
            }

            // displays the card number
            Console.WriteLine("Card ID : " + rng.getRandomNumber);
            Console.ReadLine();

         

        }

       
    }
}
