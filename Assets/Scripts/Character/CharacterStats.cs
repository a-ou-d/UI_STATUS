using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterStats", menuName = "Stats", order = 0)]

public class CharacterStats : ScriptableObject
{
    [Header("Normal Stats")]
    public int power;
    public float speed;
    public int health;
    public int wizdom;
    public int mental;

    public void AddStats(CharacterStats item)
    {
        this.power += item.power;
        this.speed += item.speed;
        this.health += item.health;
        this.wizdom += item.wizdom;
        this.mental += item.mental;
    }
}
