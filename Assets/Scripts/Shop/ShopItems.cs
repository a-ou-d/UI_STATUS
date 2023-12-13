using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Shop", menuName = "Shop/Item", order = 3)]
public class ShopItems : ScriptableObject
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
