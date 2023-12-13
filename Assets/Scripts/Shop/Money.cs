using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class Money
{
    public static int gold { get; private set; }

    public delegate void OnGoldChange();
    public static event OnGoldChange onGoldChange;

    public static void StartGold(int startingGold)
    {
        gold = startingGold;
        onGoldChange?.Invoke();
    }

    public static void AddGold(int amount)
    {
        gold += amount;
        onGoldChange?.Invoke();
    }

    public static void SpentGold(int amount)
    {
        if (gold >= amount)
        {
            gold -= amount;
            onGoldChange?.Invoke();
        }
        else
        {
            // 소지 골드가 부족합니다
        }
    }
}
