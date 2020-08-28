using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace c_oop_practice_deck_card_classes_shailza85
{
    class Deck
    {

        /*
         * Create a “Deck” class that has a “Cards” property, which is a stack of cards, and the following methods:
            Shuffle() - will randomly reorder the deck
            Draw() - will draw the top card of the deck
            Folded() - will return a list of the cards in the stack that have folded cornerscards in the stack that have folded corners, do not remove the cards from the stack
          * 
         */

       Stack<Card> cards = new Stack<Card>();
        public void Shuffle(Stack<Card> cards)
        {
            //Shuffle the existing cards using Fisher-Yates Modern
            List<Card> transformedCards = cards.ToList();
            Random r = new Random(DateTime.Now.Millisecond);
            for (int n = transformedCards.Count - 1; n > 0; --n)
            {
                //Step 2: Randomly pick a card which has not been shuffled
                int k = r.Next(n + 1);
                //Step 3: Swap the selected item 
                //        with the last "unselected" card in the collection
                Card temp = transformedCards[n];
                transformedCards[n] = transformedCards[k];
                transformedCards[k] = temp;
            }
            Stack<Card> shuffledCards = new Stack<Card>();
            foreach (var card in transformedCards)
            {
                shuffledCards.Push(card);
            }
            Console.WriteLine(shuffledCards);
        }


        public void Draw()
        {
            cards.Pop();
        }

        public void Folded()
        {

        }

      
    }
}
