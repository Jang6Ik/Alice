using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public int EnemyHp = 10;
    public int EnemyArmor = 0;
    public int EnemyDamage = 0;
    public int EnemyTurn = -1;
    public int EnemyActionNum = -1;
    public Sprite sprite;

    void Start()
    {

    }

    void Update()
    {
        if (EnemyTurn == 0)
        {
            Action(EnemyActionNum);
            SetAction();
            EnemyTurn = -1;
        }
    }

    virtual public void Action(int actionNum)
    {
        //함수 실행시 설정된 행동을 실행
    }

    virtual public void SetAction()
    {
        //랜덤으로 몬스터가 할 행동과 남은 턴을 설정
    }

    virtual public void Attack()
    {
        //공격
    }

    virtual public void Guard()
    {
        //방어
    }

    virtual public void Crowd_Control()
    {
        //상태이상
    }


    public void EnemyDie()
    {
        if (EnemyHp <= 0)
        {
            Debug.Log("Enemy Die");
        }
    }
}
