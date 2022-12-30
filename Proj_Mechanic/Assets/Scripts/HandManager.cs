using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StudPoker
{
    public class HandManager : MonoBehaviour
    {
        //TODO: Rahul - For all scripts, figure out what data needs to be public and what can be private and finally what needs to be public fot the editor only(Serialized field)
        //Also follow the same naming convention
        //Class names       PascalCase
        //Public variable   camelCase
        //Private variable  _camelCase
        //Properties        PascalCase
        //Method names      PascalCase
        //Constants         
        public DeckQueue deckObject;
        public GameObject cardPrefab;
        private int _swapChances;
        public List<Transform> cardSlots = new List<Transform>();
        public CardGO[] CardObjects = new CardGO[5];
        // Start is called before the first frame update
        void Start()
        {
            _swapChances = 3;
            foreach (Transform child in transform)
            {
                cardSlots.Add(child);
            }
        
        }

        public void DrawCard(Transform drawLocation)
        {
            GameObject newCard = Instantiate(cardPrefab, drawLocation);
            CardGO handCard = newCard.GetComponent<CardGO>();
            handCard.cardInfo = deckObject.cardDeck[0];
            deckObject.cardDeck.RemoveAt(0);
            for (int i = 0; i<CardObjects.Length; i++)
            {
                if (CardObjects[i] == null)
                {
                    CardObjects[i] = handCard;
                    return;
                }
                else { };
            }

        }
        public void DrawCard()
        {
            foreach (Transform slot in cardSlots)
            {
                if (slot.childCount >= 1) continue;
                DrawCard(slot);
            }

        }
        public void SwapCards()
        {
            for (int i = 0; i < CardObjects.Length; i++)
            {
                if (CardObjects[i].isSelected)
                {
                    Card oldCard = ScriptableObject.CreateInstance<Card>();
                    oldCard.InitCard(CardObjects[i].cardInfo.cardNo, CardObjects[i].cardInfo.suitNo);
                    deckObject.cardDeck.Add(oldCard);
                    var obtoDestroy = CardObjects[i].gameObject;
                    CardObjects[i] = null;
                    DestroyImmediate(obtoDestroy);
                }
            }
            deckObject.cardDeck.Shuffle();
            DrawCard();



        }


    }
}
