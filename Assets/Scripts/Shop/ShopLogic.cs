using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopLogic : MonoBehaviour
{
    public void BuyItem(Items item)
    {
        if (Money.gold >= item.price)
        {
            Money.SpentGold(item.price);
            // �κ��丮�� ������ �߰�
        }
        else
        {
            // ���� ��尡 �����մϴ� ����
        }
    }
}
