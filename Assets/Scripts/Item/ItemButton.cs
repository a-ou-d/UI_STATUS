using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour
{
    public Items mainItem;

    public GameObject inven;
    public ScriptableObject item;
    public Equip equipPanel;


    public bool isEquipped = false;

    private void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        if (equipPanel != null)
        {
            inven.SetActive(false);
            equipPanel.OpenPanel(item, gameObject.GetComponent<ItemButton>());
        }
    }

    //public void ToggleEquip()
    //{
    //    isEquipped = !isEquipped;
    //}
}
