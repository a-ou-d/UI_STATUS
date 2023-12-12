using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Inventory", menuName = "Inventory/Item", order = 1)]
public class Items : ScriptableObject
{
    public string itemName;
    public Sprite icon;
    public string description;

    public int price;
    public int quantity;

    public int power;
    public int speed;
    public int health;
    public int wizdom;
    public int mental;
}