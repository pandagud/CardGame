using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Game
    {
        static void Main(string[] args)
        {
            Player Nelly = new Player("Nelly");
            Player Bjørn = new Player("Bjørn");
            Player Jacob = new Player("Jacob");

            Nelly.getCards();
            Nelly.getCards();
            Nelly.Totalvalue();
            Bjørn.getCards();
            Bjørn.getCards();
            Bjørn.Totalvalue();
            Jacob.getCards();
            Jacob.getCards();
            Jacob.Totalvalue();
            Console.Read();
        }
    }
}
