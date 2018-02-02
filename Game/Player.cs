using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Player
    {
        public string Name { get; set; }
        public int TotalValue { get; set; }
        List<Cards> ListofCards = new List<Cards>();
        Deck deck  = new Deck();

        public Player(string _name)
        {
            Name = _name;
        }

        public Cards getCards()
        {
           
            ListofCards.Add(deck.dealCard());
            return deck.dealCard();
        }

        public List<Cards> Showhand()
        {
            Console.WriteLine("Color of card "+ListofCards[0].cardColor.ToString()+ " Value of card"+ListofCards[0].cardvalue.ToString());
            return ListofCards;
        }

        public void Totalvalue()
        {
            int totalvalue = 0;
            
            for (int i = 0; i < ListofCards.Count; i++)
            {
                switch (ListofCards[i].cardColor)
                {
                    case "Red":
                        totalvalue = ListofCards[i].cardvalue * 1;

                    break;
                    case "Blue":
                        totalvalue = ListofCards[i].cardvalue * 2;

                        break;
                    case "Green":
                        totalvalue = ListofCards[i].cardvalue * 3;

                        break;
                    case "Yellow":
                        totalvalue = ListofCards[i].cardvalue * 4;

                        break;
                }
            }

            Console.WriteLine(Name+"Has a totalvalue offf "+totalvalue);
           
        }
    }
}
