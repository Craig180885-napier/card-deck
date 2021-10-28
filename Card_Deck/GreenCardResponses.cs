using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Deck
{
    class GreenCardResponses : Response
    {

        public GreenCardResponses(string cardColour, int responseID, string response1, string response2, string response3, string response4) : base(cardColour, responseID, response1, response2, response3, response4)
        {
   
        }
    }
}
