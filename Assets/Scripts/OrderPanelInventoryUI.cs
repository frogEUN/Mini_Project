using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderPanelInventoryUI : MonoBehaviour
{
    public int idx;
    private Image image;

    private void Start()
    {
        image = GetComponent<Image>();
    }

    public void SetImage()
    {
        if(InventoryManager.instance.fruitsInInventory[idx]==null)
        {
            image.sprite = null;
        }
        else
        {
            image.sprite = InventoryManager.instance.fruitsInInventory[idx].fruitImage;
        }
        

    }
}
