using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Blackjack
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
           //loop through 13 faces
            for(int i =0; i < 13; i++)
            {
                //loop through 4 suits
                for(int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    //cast the enum
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }

         }


        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> temp = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randIndex = random.Next(0, Cards.Count);
                    temp.Add(Cards[randIndex]);
                    Cards.RemoveAt(randIndex);
                }

                this.Cards = temp;
            }
        }
    }
}
