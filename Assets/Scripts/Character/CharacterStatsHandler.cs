using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterStatsHandler : MonoBehaviour
{
    [SerializeField] private CharacterStats baseStats;

    public CharacterStats CurrentStats { get; private set; }
    public List<Items> StatsModifiers = new List<Items>();

    private void Awake()
    {
        UpdateCharacterStats();
    }

    public void UpdateCharacterStats()
    {
        CurrentStats = Instantiate(baseStats);

        foreach (Items item in StatsModifiers)
        {
            CurrentStats.power += item.power;
            CurrentStats.speed += item.speed;
            CurrentStats.health += item.health;
            CurrentStats.wizdom += item.wizdom;
            CurrentStats.mental += item.mental;
        }

        UpdateUI();
    }

    [SerializeField] private Text powerText;
    [SerializeField] private Text speedText;
    [SerializeField] private Text healthText;
    [SerializeField] private Text wizdomText;
    [SerializeField] private Text mentalText;

    private void UpdateUI()
    {
        powerText.text = CurrentStats.power.ToString();
        speedText.text = CurrentStats.speed.ToString();
        healthText.text = CurrentStats.health.ToString();
        wizdomText.text = CurrentStats.wizdom.ToString();
        mentalText.text = CurrentStats.mental.ToString();
    }
}
