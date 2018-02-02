using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game
{
    class Deck
    {
        public Cards dealCard()
        {
            Cards card = new Cards();
            Thread.Sleep(TimeSpan.FromMilliseconds(20));
            return card;
        }

    }
}
