using UnityEngine;
//TODO: Rahul - Scriptable Objects, and MonoBehaviours both override the constructors of scripts, so you should not have these here, potential to mess up 

namespace StudPoker
{
    [CreateAssetMenu(fileName = "card", menuName = "ScriptableObjects/createCard", order = 1)]
    public class Card : ScriptableObject
    {
        private string[] Cards = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        private string[] Suits = new string[] { "Clubs", "Diamonds", "Spades", "Hearts" };

        public int cardNo;
        public int suitNo;
        public Sprite cardImage;

        public void InitCard(int number, int suit)
        {
            cardNo = number;
            suitNo = suit;
            name = Cards[cardNo] + "_of_" + Suits[suitNo];
        }

        [ContextMenu("Create 52 Cards")]
        public void Create52Cards()
        {
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card newcard = ScriptableObject.CreateInstance<Card>();
                    newcard.InitCard(i, j);
                }

            }
        }

    }
}
