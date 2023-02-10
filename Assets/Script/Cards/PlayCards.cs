using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Script.Cards;
using System;

//<--------------------------------Current Testing Code---------------------------(Start)------>//
/*namespace DemoNamespace
{*/


    public class PlayCards : MonoBehaviour
    {
        [NonSerialized]
        public int data;
        public int data2;
        public CardData[] Cards52 = new CardData[52];
        public List <CardData> LeftCards;
        public List <CardData> Player1Cards;
        public List <CardData> Player2Cards;
        //public List <CardData> Player3Cards;
        public CardData Joker;
        //public CardData temp = new CardData(2, 3);
        public CardSpawner cardSpawner;
        void Start()
        {
            GetCards52();
            SuffleCards52();
            DealOutCards();
            GetLeft26Cards();
            GetJoker();
            cardSpawner.SpawnCards();
           // Debug.Log(temp);
        }
        void GetCards52()
        {
            int Cards52Index = 0;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    Cards52[Cards52Index] = new CardData(i, j);
                    //Debug.Log(j);
                    Cards52Index++;
                }
            }
        }
        void GetLeft26Cards()
        {
            for (int i = 26; i <= 51; i++)
            {
              LeftCards.Add(Cards52[i]);
            }
        }
        void SuffleCards52()
        {
            for (int i = 0; i < 70; i++)
            {

                int A = UnityEngine.Random.Range(0, 52);
                int B = UnityEngine.Random.Range(0, 52);
                CardData a;
                CardData b = Cards52[B];
                CardData c = Cards52[A];
                a = b;
                b = c;

                Cards52[A] = a;
                Cards52[B] = b;
            }
        }
        
        void DealOutCards()
        {
            int array1Index = 0;
            int array2Index = 0;
            for (int i = 0; i < 26; i++)
            {
                if (i % 2 == 0)
                {
                    Player1Cards.Add(Cards52[i]);
                    array1Index++;
                }
                else
                {
                    Player2Cards.Add(Cards52[i]);
                    array2Index++;
                }
            }
        }
        
        void GetJoker()
        {
        Joker = LeftCards[UnityEngine.Random.Range(0, LeftCards.Count-1)];
        LeftCards.Remove(Joker);
        }
    }
/*}*/
//<--------------------------------Current Testing Code---------------------------(End)------>//


//<--------------------------------Current Working Code---------------------------(Start)------>//
/*public class PlayCards : MonoBehaviour
{
    [SerializeField]
    public CardD[] Cards52 = new CardD[52];
    public CardD temp = new CardD(2, 3);
    void Start()
    {
        GetCards52();
        Debug.Log(temp);
    }
    void GetCards52()
    {
        int Cards52Index = 0;
        for(int i = 1; i<=4; i++)
        {
            for(int j = 1; j<=13; j++)
            {
                Cards52[Cards52Index] = new CardD(i, j);
                Cards52Index++;
            }
        }
    }
}

[System.Serializable]
public enum CardType
{
    None = 0,
    Clubs,
    Spades,
    Diamonds,
    Hearts
}
public enum CardValue
{
    None = 0,
    Ace,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King
}

[System.Serializable]
public class CardD
{
    // [SerializeField]


    public CardType ThisCardType;
    public CardValue ThisCardValue;
    public CardD(int Type, int Value)
    {
        ThisCardType = (CardType)Type;
        ThisCardValue = (CardValue)Value;
    }
}*/
//<--------------------------------Current Working Code---------------------------(End)------>//