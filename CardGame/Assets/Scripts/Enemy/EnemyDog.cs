using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDog : EnemyBase
{
    void Start()
    {
        EnemyHp = 10;
        EnemyDamage = 1;
        sprite = GetComponent<Sprite>();
    }

    void Update()
    {
        
    }

}
