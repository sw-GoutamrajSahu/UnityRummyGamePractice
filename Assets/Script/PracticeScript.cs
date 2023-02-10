using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class PracticeScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI Q1TextBox;
    [SerializeField] TextMeshProUGUI Q2TextBox;
    [SerializeField] TextMeshProUGUI Q3TextBox;
    [SerializeField] TextMeshProUGUI Q4TextBox;
    [SerializeField] TextMeshProUGUI Q5TextBox;

    public int[] IntArr;
    public string[] StringArrQ3;
    public string StringQ4;
    public string StringQ5;
    void Start()
    {
       StartCoroutine(PrintHelloWorld("Hello World", 2));

        Q2TextBox.text = "Q2) ";
        foreach (var item in IntArr)
        {
            Q2TextBox.text += item+" ";
        }

        Q3TextBox.text = "Q3) ";
        foreach (var item in StringArrQ3)
        {
            Q3TextBox.text += item+", ";
        }

        Q4TextBox.text = "Q4) " + StringQ4;

        Q5TextBox.text = StringQ5;
    }

    private IEnumerator PrintHelloWorld(string message, float sec)
    {
        yield return new WaitForSeconds(sec);
        Debug.Log(message);
        Q1TextBox.text = message;
    }
    
    public void SortArray()
    {
        for (int i = 0; i < IntArr.Length - 1; i++)
        {
            for (int j = 0; j < IntArr.Length - 1 - i; j++)
            {
                if (IntArr[j] > IntArr[j + 1])
                {
                    int temp = IntArr[j];
                    IntArr[j] = IntArr[j + 1];
                    IntArr[j + 1] = temp;
                }
            }
        }

        Q2TextBox.text = "Q2) ";
        foreach (var item in IntArr)
        {
            Q2TextBox.text += item + " ";
        }
        Debug.Log(Q2TextBox.text);
    }

    public void SortStringArray()
    {

        for (int i = 0; i < StringArrQ3.Length - 1; i++)
        {
            for (int j = i + 1; j < StringArrQ3.Length - 1; j++)
            {
                if (StringArrQ3[i].CompareTo(StringArrQ3[j+1]) > 0)
                {
                    string temp = StringArrQ3[i];
                    StringArrQ3[i] = StringArrQ3[j+1];
                    StringArrQ3[j + 1] = temp;
                }
            }
        }

        Q3TextBox.text = "Q3) ";
        foreach (var item in StringArrQ3)
        {
            Q3TextBox.text += item + ", ";
        }
        Debug.Log(Q3TextBox.text);  
    }

    public void checkPalindrome()
    {
        bool isPal = true;
        for (int i = 0, j = StringQ4.Length-1; i <= j ;i++,j--)
        {
            if (StringQ4[i] != StringQ4[j])
            {
                isPal = false;
                break;
            }
        }
        Debug.Log(Q4TextBox.text + " is Palindrome : " + isPal);
        Q4TextBox.text = Q4TextBox.text + " is Palindrome : " + isPal;
    }

    public void toUpperCase()
    {
        string tempStr = "";
        for(int i = 0; i< StringQ5.Length; i++)
        {
            if(Char.IsLetter(StringQ5[i]) && Char.IsLower(StringQ5[i]))
            {
                tempStr += (Char)((int)StringQ5[i] - 32);
                //tempStr += Char.ToUpper(StringQ5[i]);
            }
            else
            {
                tempStr += StringQ5[i];
            } 
        }
        Debug.Log(tempStr);
        Q5TextBox.text = tempStr;
    }

}
