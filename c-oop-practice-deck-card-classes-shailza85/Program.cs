using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck theDeck = new Deck()
            {
                Cards = new Stack<Card>()
            };

            // https://stackoverflow.com/questions/105372/how-to-enumerate-an-enum
            // Foreach possible value in the SuitValue enum...
            foreach (Card.SuitValue suit in Enum.GetValues(typeof(Card.SuitValue)))
            {
                foreach (Card.NumberValue number in Enum.GetValues(typeof(Card.NumberValue)))
                {
                    //Stops us from having suited jokers.
                    if (number != Card.NumberValue.Joker)
                    {
                        // Push one card of each number in each suit into the deck.
                        theDeck.Cards.Push(new Card()
                        {
                            Suit = suit,
                            Number = number,
                            Brand = "Bicycle",
                            FolderCorner = false
                        });
                    }
                }
            }
            theDeck.Cards.Push(new Card()
            {
                Brand = "Bicycle",
                Number = Card.NumberValue.Joker,
                Suit = null,
                FolderCorner = false
            });

            theDeck.Cards.Push(new Card()
            {
                Brand = "Bicycle",
                Number = Card.NumberValue.Joker,
                Suit = null,
                FolderCorner = false
            });

            theDeck.Shuffle();
        } // End Main();

    }
}