using System;
using System.Collections.Generic;
using System.Text;

namespace c_oop_practice_deck_card_classes_shailza85
{
    public class Card
    {

        /*
        *  Create a “Card” class that has the following properties:
          Brand (Bicycle, Bee, etc)
          Suit (Diamonds, Hearts, Spades, Clubs) 
          Number (Ace, 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King, Joker)
          Joker must have a null suit, all others must have a suit
          Folded Corner (true / false)

   * */      
        public string Brand { get; set; }
        public Suit Suit { get; set; }
        //public Number Number { get; set; }
        public string Number { get; set; }
        public bool FoldedCorner { get; set; } 
        
        public Card()
        {
            Brand = "Bicycle";
            Suit = new Suit();
            Number = "2";
            FoldedCorner = true;

        }

        public Card(Suit suit,string number)
        {
            Suit = suit;
            this.Number = number;
        }


    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Spades,
        Hearts
    }
    public enum Number
    {
        Two = 2,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack = 10,
        Queen = 10,
        King = 10,
        Ace,
    }
}
