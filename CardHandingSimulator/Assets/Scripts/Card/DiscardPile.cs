using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DiscardPile : Pile
{
    void Start()
    {
        pile = new List<CardInit>();

        pileCount = transform.Find("Count").GetComponent<Text>();
        pileCount.text = pile.Count.ToString();
    }
}
