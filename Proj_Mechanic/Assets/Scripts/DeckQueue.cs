using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StudPoker
{
    public class DeckQueue : MonoBehaviour
    {
        public List<Card> cardDeck = new List<Card>();
        int uniqueCards = 13;
        int uniqueSuits = 4;
        


        // Start is called before the first frame update
        void Start()
        {
            CreateDeck();
            Debug.Log(cardDeck[1]);
      
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void CreateDeck()
        {
            for (int i = 0; i < uniqueCards; i++)
            {
                for (int j = 0; j < uniqueSuits; j++)
                {
                    Card newcard = ScriptableObject.CreateInstance<Card>();
                    //newcardcardManager.createCard(i, j);
                    newcard.InitCard(i, j);
                    cardDeck.Add(newcard);
                    //create card
                    //enqueue card
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
