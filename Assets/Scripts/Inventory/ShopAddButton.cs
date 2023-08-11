using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopAddButton : MonoBehaviour
{
    public Fruit fruit;

    public void ClickShopAddButton()
    {
        InventoryManager.instance.AddFruit(fruit);
    }
}
