using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{
    public static List<CardInit> cardList = new List<CardInit>();
    
    void Awake()
    {
        cardList.Add(new CardInit(0, "♥", 1, 0, "This is ♥."));
        cardList.Add(new CardInit(1, "◈", 1, 1, "This is ◈."));
        cardList.Add(new CardInit(2, "♣", 2, 1, "This is ♣."));
        cardList.Add(new CardInit(3, "♠", 2, 2, "This is ♠."));
        cardList.Add(new CardInit(4, "JOKER", 3, 3, "JOKER."));
    }
}
