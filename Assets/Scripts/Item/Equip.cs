using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class Equip : MonoBehaviour
{
    public GameObject inven;
    public GameObject equipPanel;
    public Text itemNameText;
    public Text itemDescriptionText;
    public Text itemStatsText;
    public Button equipButton;
    public Button backButton;

    private static ItemButton currentButton;
    private Items currentItem;

    public CharacterStatsHandler characterStatsHandler;

    public List<ItemButton> allItemButtons;

    private void Start()
    {
        equipButton.onClick.AddListener(EquipItem);
        backButton.onClick.AddListener(ClosePanel);
    }

    public void OpenPanel(ScriptableObject itemObject, ItemButton itembutton)
    {
        currentItem = itemObject as Items;
        currentButton = itembutton;

        if (currentItem != null)
        {
            itemNameText.text = currentItem.itemName;
            itemDescriptionText.text = currentItem.description;

            string statsText = "";
            if (currentItem.power != 0)
            {
                statsText += $"Èû: +{currentItem.power}\n";
            }
            if (currentItem.speed != 0)
            {
                statsText += $"¹ÎÃ¸: +{currentItem.speed}\n";
            }
            if (currentItem.health != 0)
            {
                statsText += $"Ã¼·Â: +{currentItem.health}\n";
            }
            if (currentItem.wizdom != 0)
            {
                statsText += $"Áö´É: +{currentItem.wizdom}\n";
            }
            if (currentItem.mental != 0)
            {
                statsText += $"Á¤½Å·Â: +{currentItem.mental}";
            }

            itemStatsText.text = statsText;
            equipPanel.SetActive(true);
        }
    }

    public void EquipItem()
    {
        //ItemButton itemButton = allItemButtons.Find(button => button.mainItem == currentItem);

            currentButton.isEquipped = !currentButton.isEquipped;

            if (currentButton.isEquipped)
            {
                characterStatsHandler.StatsModifiers.Add(currentItem);
            }
            else
            {
                characterStatsHandler.StatsModifiers.Remove(currentItem);
            }

            characterStatsHandler.UpdateCharacterStats();

            UpdateItemEquipStatus();
    }

    public void ClosePanel()
    {
        equipPanel.SetActive(false);
        inven.SetActive(true);
    }

    public void UpdateItemEquipStatus()
    {
        foreach (var itemButton in allItemButtons)
        {
            if (itemButton.isEquipped)
            {
                itemButton.GetComponent<Image>().color = new Color(0.5f, 0.5f, 0.5f, 1);
            }
            else
            {
                itemButton.GetComponent<Image>().color = Color.white;
            }

        }
    }
}
