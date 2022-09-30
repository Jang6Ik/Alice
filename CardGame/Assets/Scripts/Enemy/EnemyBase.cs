using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public int EnemyHp = 10;
    public int EnemyArmor = 0;
    public int EnemyDamage = 0;
    public int EnemyTurn = 0;

    public Sprite sprite;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    virtual public void Action()
    {
       
    }

    public void EnemyDie()
    {
        if (EnemyHp <= 0)
        {
            Debug.Log("Enemy Die");
        }
    }
}
