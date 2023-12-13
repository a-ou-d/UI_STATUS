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
            // 인벤토리에 아이템 추가
        }
        else
        {
            // 소지 골드가 부족합니다 띄우기
        }
    }
}
