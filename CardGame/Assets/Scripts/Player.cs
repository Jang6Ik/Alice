using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int PlayerHp = 40;
    public int PlayerArmor;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void PlayerGameOver()
    {
        if (PlayerHp <= 0)
        {
            Debug.Log("GameOver");
        }
    }
}
