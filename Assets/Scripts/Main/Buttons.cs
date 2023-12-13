using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject mainCanvas;
    public GameObject statsCanvas;
    public GameObject invenCanvas;
    public GameObject shopCanvas;

    public void ShopBtn()
    {
        mainCanvas.SetActive(false);
        shopCanvas.SetActive(true);     
    }

    public void StatsBtn()
    {
        mainCanvas.SetActive(false);
        statsCanvas.SetActive(true);
    }

    public void InvenBtn()
    {
        mainCanvas.SetActive(false);
        invenCanvas.SetActive(true);
    }

    public void StatsToMain()
    {
        statsCanvas.SetActive(false);
        mainCanvas.SetActive(true);
    }

    public void InvenToMain()
    {
        invenCanvas.SetActive(false);
        mainCanvas.SetActive(true);
    }

    public void ShopToMain()
    {
        shopCanvas.SetActive(false);
        mainCanvas.SetActive(true);
    }
}
