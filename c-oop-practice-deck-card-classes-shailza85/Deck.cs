using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpOOP
{
    class Deck
    {
        /*
        Create a “Deck” class that has a “Cards” property, which is a stack of cards, and the following methods:
        Shuffle() - will randomly reorder the deck
        Draw() - will draw the top card of the deck
        Folded() - will return a list of the cards in the stack that have folded corners, do not remove the cards from the stack
        */

        // Create a new instance of a random generator.
        // It must be static because otherwise if you generate multiple decks and shuffle them, you will likely get the same order, as a quirk of how the Random class works.
        private static Random rng = new Random();

        public Stack<Card> Cards { get; set; }

        // https://stackoverflow.com/questions/33643104/shuffling-a-stackt
        public void Shuffle()
        {
            // Take Cards, and call OrderBy on it. OrderBy is a LINQ method that will order the contents of a List (or similar data structure) by the lambda in it's parentheses. 
            // A lambda function is an arrow function. Left of the "=>" is the argument, and right of it is the return. 
            // The lambda in this case, rather than ordering by a property of "x" (the item in the Stack), we are ordering by a random number.
            // A usual lambda for OrderBy would be something like "x => x.Suit".
            // Once the random order has been achieved, it returns a generic form of a collection, so we have to cast it to a stack.

            Cards = new Stack<Card>(Cards.OrderBy(x => rng.Next()));
        }

        public Card Draw()
        {
            // Grabs the top card from the deck.
            return Cards.Pop();
        }

        public List<Card> Folded()
        {
            List<Card> foldedCards = new List<Card>();
            foreach (Card card in Cards)
            {
                if (card.FolderCorner)
                {
                    foldedCards.Add(card);
                }
            }
            return foldedCards;
        }
    }
}