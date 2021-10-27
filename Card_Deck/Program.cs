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
            Console.WriteLine(rng.getRandomNumber);
            Console.ReadLine();
            
        }
    }
}
