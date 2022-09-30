using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;

    public int PlayerHp = 40;
    public int PlayerArmor;

    public bool isSturn = false;

    private void Awake()
    {
        Player.instance = this;
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (!isSturn)
        {
            StartCoroutine(DebugLog());
        }
    }

    IEnumerator DebugLog()
    {
        Debug.Log("OK");
        yield return new WaitForSeconds(2.0f);
    }

    public void PlayerGameOver()
    {
        if (PlayerHp <= 0)
        {
            Debug.Log("GameOver");
        }
    }
}
