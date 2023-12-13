using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class MainGold : MonoBehaviour
{
    public TMP_Text goldText;

    private void Start()
    {
        Money.onGoldChange += UpdateGold;
        UpdateGold();
    }

    private void OnDestroy()
    {
        Money.onGoldChange -= UpdateGold;
    }

    private void UpdateGold()
    {
        goldText.text = $"{Money.gold} G";
    }
}
