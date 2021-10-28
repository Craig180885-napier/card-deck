using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Deck
{
    class RandomNumberGenerator
    {
        private int _randomNumber;
        

        public RandomNumberGenerator(int range)
        {
            // Randomw number code below was sourced from https://stackoverflow.com/questions/3975290/produce-a-random-number-in-a-range-using-c-sharp

            Random r = new Random();
            _randomNumber = r.Next(1, range);            
        }

        public int getRandomNumber
        {
            get { return _randomNumber; }
        }
    }
}
