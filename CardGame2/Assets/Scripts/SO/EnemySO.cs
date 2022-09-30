using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Enemy
{
    public string Name;
    public int Health;
    public Sprite sprite;
}

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy/Create Enemy")]
public class EnemySO : ScriptableObject
{
    public Enemy[] enemies;
}
