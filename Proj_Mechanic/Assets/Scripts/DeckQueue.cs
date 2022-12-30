using System.Collections.Generic;
using UnityEngine;

namespace StudPoker
{
    public class DeckQueue : MonoBehaviour
    {
        public List<Card> cardDeck = new List<Card>();
        int uniqueCards = 13;
        int uniqueSuits = 4;
       
        void Start()
        {
            CreateDeck();
            Debug.Log(cardDeck[1]);
      
        }

        void Update()
        {
        
        }

        //TODO: Rahul - separate this logic into an another file where you can create a deck of cards in the project folder instead.
        //Then manually go in and add images to each card.
        //Finally at the start of this script, find all the scriptable object cards in the project folder (whatever path you choose)
        //And add them all to a new list to be used here. You might need to "CreateInstance" with the data in the project folder and then use that at runtime, so you don't fuck up the base data.
        public void CreateDeck()
        {
            for (int i = 0; i < uniqueCards; i++)
            {
                for (int j = 0; j < uniqueSuits; j++)
                {
                    Card newcard = ScriptableObject.CreateInstance<Card>();
                    newcard.InitCard(i, j);
                    cardDeck.Add(newcard);
                }

            }
            cardDeck.Shuffle();
        }
        public void ShuffleDeck()
        {
            cardDeck.Shuffle();

        }

    }
}
