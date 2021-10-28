using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Deck
{
    class ID
    {
        private static ID instance;
        private int _nextCardID;       
        private ID()
        {
            _nextCardID = 1;
        }

        public static ID Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ID();
                }
                return instance;
            }
        }

        public int currentCardID()
        {
            return _nextCardID;
        }
   
        public int nextCardID()
        {
            _nextCardID++;
            return _nextCardID;
        }
    }
}
