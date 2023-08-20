using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderPanelInventoryUI : MonoBehaviour
{
    public int idx;
    public Image image;
    public InventoryManager inventoryManager;

    private void Start()
    {
        //image = GetComponent<Image>();
    }

    public void SetImage()
    {
        image.sprite = null;
        if (GameData.inventory[idx] == null) return;
        image.sprite = GameData.inventory[idx].fruitImage;

    }
}
