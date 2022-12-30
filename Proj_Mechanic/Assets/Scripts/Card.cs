using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StudPoker
{
    [CreateAssetMenu(fileName = "card", menuName = "ScriptableObjects/createCard", order = 1)]
    public class Card : ScriptableObject
    {
        private string[] Cards = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        private string[] Suits = new string[] { "Clubs", "Diamonds", "Spades", "Hearts" };
        //public class CardComponents
        //{
            //public GameObject cardOb;
            public int cardNo;
            public int suitNo;
        //public string name;
            //public Sprite cardImage;
            public Card(int number, int suit)
            {
                cardNo = number;
                suitNo = suit;
            }
            public Card()
            {
                cardNo = 1;
                suitNo = 1;
            }
        public void InitCard(int number, int suit)
        {
            cardNo = number;
            suitNo = suit;
            name = Cards[cardNo] + "_of_" + Suits[suitNo];
        }

    }
}
