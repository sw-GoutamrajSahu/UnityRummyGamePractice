using Assets.Script.Cards;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CardSpawner : MonoBehaviour
{
    public GameObject CardPrefab;
    public PlayCards PlayCardsData;
    /*public List<GameObject> Player1Cards;
    public List<GameObject> Player2Cards;*/
    public List<GameObject> LeftCards;
    public Transform parentObjectPlayer1Cards;
    public Transform parentObjectPlayer2Cards;
    public Transform parentObjectLeftCards;
    public Transform parentObjectJoker;

    //<---------------Suits Variables-------(Start)---->//
    public Sprite diamond;
    public Sprite clover;
    public Sprite heart;
    public Sprite spade;
    public Sprite queen;
    public Sprite king;
    public Sprite jack;
    //<---------------Suits Variables-------(End)---->//
    

    public void SpawnCards() 
    {
       
        Debug.Log(PlayCardsData.Player1Cards.Count);
        int XCordinate = 0;
       //<----------------------Spawn Cards for Player1---------------(Start)---->//
       foreach(CardData card in PlayCardsData.Player1Cards)
        {
            GameObject temp = Instantiate(CardPrefab, parentObjectPlayer1Cards);
            temp.transform.position = new Vector2(temp.transform.position.x + XCordinate, temp.transform.position.y + 60);
            if(card.ThisCardValue == CardValue.Jack || card.ThisCardValue == CardValue.Queen || card.ThisCardValue == CardValue.King)
            {
                temp.GetComponent<CardRenderer>().Initialize(getSuitSprite(card),GetQueenOrKingOrJack(card), getValue(card).ToString(), PlayCardsData.Joker);
            }
            else
            {
                temp.GetComponent<CardRenderer>().Initialize(getSuitSprite(card), getValue(card).ToString(), PlayCardsData.Joker);
            }
           // XCordinate += 40;
        }
        XCordinate = 0;
        //<----------------------Spawn Cards for Player1---------------(End)---->//

        //<----------------------Spawn Cards for Player2---------------(Start)---->//
        foreach (CardData card in PlayCardsData.Player2Cards)
        {
            GameObject temp = Instantiate(CardPrefab, parentObjectPlayer2Cards);
            temp.transform.position = new Vector2(temp.transform.position.x + XCordinate, temp.transform.position.y + 60);
            if (card.ThisCardValue == CardValue.Jack || card.ThisCardValue == CardValue.Queen || card.ThisCardValue == CardValue.King)
            {
                temp.GetComponent<CardRenderer>().Initialize(getSuitSprite(card), GetQueenOrKingOrJack(card), getValue(card).ToString(), PlayCardsData.Joker);
            }
            else
            {
                temp.GetComponent<CardRenderer>().Initialize(getSuitSprite(card), getValue(card).ToString(), PlayCardsData.Joker);
            }
          //  XCordinate += 40;
        }
        XCordinate = 0;
        //<----------------------Spawn Cards for Player2---------------(End)---->//

        //<----------------------Spawn Left Cards---------------------(Start)---->//
        foreach (CardData card in PlayCardsData.LeftCards)
        {
            GameObject temp = Instantiate(CardPrefab, parentObjectLeftCards);
            temp.transform.position = new Vector2(temp.transform.position.x + XCordinate, temp.transform.position.y + 60);
            if (card.ThisCardValue == CardValue.Jack || card.ThisCardValue == CardValue.Queen || card.ThisCardValue == CardValue.King)
            {
                temp.GetComponent<CardRenderer>().Initialize(getSuitSprite(card), GetQueenOrKingOrJack(card), getValue(card).ToString(), PlayCardsData.Joker);
            }
            else
            {
                temp.GetComponent<CardRenderer>().Initialize(getSuitSprite(card), getValue(card).ToString(), PlayCardsData.Joker);
            }
           // XCordinate += 40;
        }
        XCordinate = 0;
        //<----------------------Spawn Left Cards----------------------(End)---->//

        //<----------------------Joker Card---------------------(Start)---->//
            GameObject tempJoker = Instantiate(CardPrefab, parentObjectJoker);
            tempJoker.transform.position = new Vector2(tempJoker.transform.position.x, tempJoker.transform.position.y + 60);
            if (PlayCardsData.Joker.ThisCardValue == CardValue.Jack || PlayCardsData.Joker.ThisCardValue == CardValue.Queen || PlayCardsData.Joker.ThisCardValue == CardValue.King)
            {
              tempJoker.GetComponent<CardRenderer>().Initialize(getSuitSprite(PlayCardsData.Joker), GetQueenOrKingOrJack(PlayCardsData.Joker), getValue(PlayCardsData.Joker).ToString(), PlayCardsData.Joker);
            }
            else
            {
              tempJoker.GetComponent<CardRenderer>().Initialize(getSuitSprite(PlayCardsData.Joker), getValue(PlayCardsData.Joker).ToString(), PlayCardsData.Joker);
            }
            
        //<----------------------Joker Card----------------------(End)---->//
    }

    public string getValue(CardData card)
    {
        string temp = null;
        if(card.ThisCardValue == CardValue.Ace)
        {
            temp= "1";
            return temp;
        }
        if (card.ThisCardValue == CardValue.Two)
        {
            temp = "2";
            return temp;
        }
        if (card.ThisCardValue == CardValue.Three)
        {
            temp = "3";
            return temp;
        }
        if (card.ThisCardValue == CardValue.Four)
        {
            temp = "4";
            return temp;
        }
        if (card.ThisCardValue == CardValue.Five)
        {
            temp = "5";
            return temp;
        }
        if (card.ThisCardValue == CardValue.Six)
        {
            temp = "6";
            return temp;
        }
        if (card.ThisCardValue == CardValue.Seven)
        {
            temp = "7";
            return temp;
        }
        if (card.ThisCardValue == CardValue.Eight)
        {
            temp = "8";
            return temp;
        }
        if (card.ThisCardValue == CardValue.Nine)
        {
            temp = "9";
            return temp;
        }
        if (card.ThisCardValue == CardValue.Ten)
        {
            temp = "10";
            return temp;
        }
        if (card.ThisCardValue == CardValue.Jack)
        {
            temp = "J";
            return temp;
        }
        if (card.ThisCardValue == CardValue.Queen)
        {
            temp = "Q";
            return temp;
        }
        if (card.ThisCardValue == CardValue.King)
        {
            temp = "K";
            return temp;
        }
        return temp;
    }
    public Sprite getSuitSprite(CardData card)
    {
        Sprite temp = null;
        if (card.ThisCardType == CardType.Spades)
        {
            temp = spade;
            return temp;
        }
        if (card.ThisCardType == CardType.Hearts)
        {
            temp = heart;
            return temp;
        }
        if (card.ThisCardType == CardType.Diamonds)
        {
            temp = diamond;
            return temp;
        }
        if (card.ThisCardType == CardType.Clubs)
        {
            temp = clover;
            return temp;
        }
        return temp;
    }

    public Sprite GetQueenOrKingOrJack(CardData card)
    {
        Sprite temp = null;
        if (card.ThisCardValue == CardValue.Queen)
        {
            temp = queen;
            return temp;
        }
        if (card.ThisCardValue == CardValue.King)
        {
            temp = king;
            return temp;
        }
        if (card.ThisCardValue == CardValue.Jack)
        {
            temp = jack;
            return temp;
        }
        return temp;
    }

}
