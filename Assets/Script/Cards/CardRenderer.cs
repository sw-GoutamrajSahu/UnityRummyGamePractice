using Assets.Script.Cards;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardRenderer : MonoBehaviour
{
    // Reference these via the Inspector in the prefab
    [SerializeField] private Image _Big_Image;
    public GameObject _Big_Image_GameObj;
    /*  [SerializeField] private Image _Queen_Image;
      [SerializeField] private Image _King_Image;
      [SerializeField] private Image _Kin_Image;*/
    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] TextMeshProUGUI _text2;
    [SerializeField] private Image _Small_Image;
    [SerializeField] private Image _Small_Image2;
    public GameObject JokerIcon;
    //PlayCards CurrentPlayingData;

    public void Initialize(Sprite sprite, String text, CardData JokerData)
    {
        
        _Small_Image.sprite = sprite;
        _Small_Image2.sprite = sprite;
        _Big_Image.sprite = sprite;
        _text.text = text;
        _text2.text = text;
        if (sprite.name == "diamond" || sprite.name == "heart")
        {
            _Small_Image.GetComponent<Image>().color = new Color(255, 0, 0);
            _Small_Image2.GetComponent<Image>().color = new Color(255, 0, 0);
            _Big_Image.GetComponent<Image>().color = new Color(255, 0, 0);

            _text.color = Color.red;
            _text2.color = Color.red;
        }
        else
        {
            _Small_Image.GetComponent<Image>().color = Color.black;
            _Small_Image2.GetComponent<Image>().color = Color.black;
            _Big_Image.GetComponent<Image>().color = Color.black;

            _text.color = Color.black;
            _text2.color = Color.black;
        }

        //<-------------------Make Jocker icon visible------------------(Start)-------->//
        if (JokerData.ThisCardValue == CardValue.Queen)
        {
            if(text == "Q")
            {
                JokerIcon.SetActive(true);
            }
            return;
        }
        if (JokerData.ThisCardValue == CardValue.King)
        {
            if (text == "K")
            {
                JokerIcon.SetActive(true);
            }
            return;
        }
        if (JokerData.ThisCardValue == CardValue.Jack)
        {
            if (text == "J")
            {
                JokerIcon.SetActive(true);
            }
            return;
        }
        if (text != "K" && text != "Q" && text != "J" && ((int)JokerData.ThisCardValue) == int.Parse(text))
        {
            JokerIcon.SetActive(true);
        }
        //<-------------------Make Jocker icon visible------------------(End)-------->//
    }

    //<-----------------------------------------Section to render special cards like Queen, King, Jack Or Ace----------------(Start)-----------------------<//
    public void Initialize(Sprite sprite,Sprite KingOrQueenOrJackOrAce, String text, CardData JokerData)
    {
       // Debug.Log("get");
        _Small_Image.sprite = sprite;
        _Small_Image2.sprite = sprite;
        _Big_Image.sprite = KingOrQueenOrJackOrAce;
        _Big_Image_GameObj.GetComponent<RectTransform>().sizeDelta = new Vector2(110f,180f);
        _text.text = text;
        _text2.text = text;
        if (sprite.name == "diamond" || sprite.name == "heart")
        {
            _Small_Image.GetComponent<Image>().color = new Color(255, 0, 0);
            _Small_Image2.GetComponent<Image>().color = new Color(255, 0, 0);
            //_Big_Image.GetComponent<Image>().color = new Color(255, 0, 0);

            _text.color = Color.red;
            _text2.color = Color.red;
        }
        else
        {
            _Small_Image.GetComponent<Image>().color = Color.black;
            _Small_Image2.GetComponent<Image>().color = Color.black;
            //_Big_Image.GetComponent<Image>().color = Color.black;

            _text.color = Color.black;
            _text2.color = Color.black;
        }

        
        //<-------------------Make Jocker icon visible------------------(Start)-------->//
        if (JokerData.ThisCardValue == CardValue.Queen)
        {
            if (text == "Q")
            {
                JokerIcon.SetActive(true);
            }
            return;
        }
        if (JokerData.ThisCardValue == CardValue.King)
        {
            if (text == "K")
            {
                JokerIcon.SetActive(true);
            }
            return;
        }
        if (JokerData.ThisCardValue == CardValue.Jack)
        {
            if (text == "J")
            {
                JokerIcon.SetActive(true);
            }
            return;
        }
        if (text != "K" && text != "Q" && text != "J" && ((int)JokerData.ThisCardValue) == int.Parse(text))
        {
            JokerIcon.SetActive(true);
        }
        //<-------------------Make Jocker icon visible------------------(End)-------->//
    }
    //<-----------------------------------------Section to render special cards like Queen, King, Jack Or Ace----------------(End)-----------------------<//
}
