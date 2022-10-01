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
        //�Լ� ����� ������ �ൿ�� ����
    }

    virtual public void SetAction()
    {
        //�������� ���Ͱ� �� �ൿ�� ���� ���� ����
    }

    virtual public void Attack()
    {
        //����
    }

    virtual public void Guard()
    {
        //���
    }

    virtual public void Crowd_Control()
    {
        //�����̻�
    }


    public void EnemyDie()
    {
        if (EnemyHp <= 0)
        {
            Debug.Log("Enemy Die");
        }
    }
}
