using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Cards
    {
        public string cardColor { get; set; }
        public int cardvalue { get; set; }

        private Random random1;
        private Random random2;
        private string[] colorlist = {"Red", "Blue", "Green", "Yellow"};
        public Cards()
        {
            random1 = new Random();
            random2 = new Random();
            cardColor = setCardcolor();
            cardvalue = setCardValue();
        }
    

        public string setCardcolor()
        {
            
            return colorlist[random1.Next(0, colorlist.Length)];
        }

        public int setCardValue()
        {
            return random2.Next(1, 8);
        }
    }
}
