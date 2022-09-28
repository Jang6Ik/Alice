using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    [SerializeField]
    GameObject gamepanel;
    List<GameObject> slot = new List<GameObject>();
    // Start is called before the first frame update
    [SerializeField]
    Slider enemyHPslider;
    [SerializeField]
    GameObject enemyfill;
    [SerializeField]
    Text enemyHPtext;
    [SerializeField]
    int enemyhp;
    [SerializeField]
    Button submission;

    int enemymaxhp =100;
    void Start()
    {
        enemyhp = 100;
        Findslot();
        findgamepanel();

        
    }

    // Update is called once per frame
    void Update()
    {
        enemyHPtext.text = enemyhp + " / " + enemymaxhp;
        enemyHPslider.value = (float)enemyhp / (float)enemymaxhp;
    }
    void findgamepanel()
    {
        gamepanel = GameObject.Find("gamepanel");
    }
    void Findslot()
    {
        GameObject[] pp = GameObject.FindGameObjectsWithTag("gameslot");
        for(int i = 0; i < pp.Length; i++)
        {
            slot.Add(pp[i]);
        }
    }



    void send()
    {
        for (int i = 0; i < slot.Count; i++)
        {
            GameObject parent = slot[i].transform.parent.gameObject;
            Debug.Log(slot[i].name);
            Transform child;

            if(slot[i].transform.childCount > 0) //슬롯에 카드가 존재한다면
            {
                Debug.Log("슬롯 0번 : " + slot[i].transform.GetChild(0));
                child = slot[i].transform.GetChild(0).transform;   //카드정보 저장
                Debug.Log("child 이름 : " + child.name);


                char a = parent.name[0]; //슬롯이 어떠한 행동을 하는지 판단하는부분
                if (a == 'h') //공격일때
                {
                    int number =0;
                     number   = (int)child.gameObject.GetComponent<Card>().number; //넘버값가져오기
                    Debug.Log("넘버 : " + number);
                    enemyhp -= number; 
                }

            }

           

        }

        for (int i = 0; i < slot.Count; i++)
        {
           // Destroy(slot[i].transform.GetChild(0));
        }

            if (enemyhp <= 0)
        {
            enemyfill.SetActive(false);  //피 없어지면 조금 남는거 없애기
        }
        //slot.Clear();
    }

    public void submission1()
    {
        
        send();
    }
}
