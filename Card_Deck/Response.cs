using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Deck
{
    class Response
    {
        private string _cardColour;
        private int _responseID;
        private string _response1;
        private string _response2;
        private string _response3;
        private string _response4;


        public Response(string cardColour, int responseID, string response1, string response2, string response3, string response4)
        {
            _cardColour = cardColour;
            _responseID = responseID;
            _response1 = response1;
            _response2 = response2;
            _response3 = response3;
            _response4 = response4;
        }

        public string cardColour
        {
            get
            {
                return _cardColour;
            }
        }

        public int responseID
        {
            get
            {
                return _responseID;
            }
        }

        public string response1
        {
            get
            {
                return _response1;
            }
        }

        public string response2
        {
            get
            {
                return _response2;
            }
        }

        public string response3
        {
            get
            {
                return _response3;
            }
        }

        public string response4
        {
            get
            {
                return _response4;
            }
        }
    }
}
