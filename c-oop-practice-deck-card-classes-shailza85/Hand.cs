using System;
using System.Collections.Generic;
using System.Text;

namespace c_oop_practice_deck_card_classes_shailza85
{
    class Hand
    {
        /*Create a “Hand” class that has a “Cards” property, which is a list of cards. 
         * */
     

        public List<Card> Cards { get; set; }

        public Hand()
        {
            Cards = new List<Card>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                for (int y = 2; y < 11; y++)
                {
                    Cards.Add(new Card(suit, y.ToString()));
                }
                Cards.Add(new Card(suit, "A"));
                Cards.Add(new Card(suit, "J"));
                Cards.Add(new Card(suit, "Q"));
                Cards.Add(new Card(suit, "K"));
            }
        }

    }
}
