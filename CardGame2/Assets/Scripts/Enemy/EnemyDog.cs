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
    override public void Action(int actionNum)
    {
        //함수 실행시 설정된 행동을 실행
    }

    override public void SetAction()
    {
        int random = Random.Range(0, 3);
        switch (random)
        {
            case 0:
                EnemyActionNum = 0;
                EnemyTurn = 3;
                break;
            case 1:
                EnemyActionNum = 1;
                EnemyTurn = 2;
                break;
            case 2:
                EnemyActionNum = 2;
                EnemyTurn = 1;
                break;
        }
    }

    override public void Attack()
    {
        //공격
        Player.instance.PlayerHp -= 1;
    }

    override public void Guard()
    {
        //방어
        EnemyArmor += 2;
    }

    override public void Crowd_Control()
    {
        //상태이상
        Player.instance.isSturn = true;
    }
}
