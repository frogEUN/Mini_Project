using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderButton : MonoBehaviour
{
    public GameObject orderPanel;
    public OrderPanelInventoryUI[] inventoryUI;

    private void Start()
    {
        orderPanel.SetActive(false);
    }

    public void OrderButtonClick()
    {
        orderPanel.SetActive(true);
        for (int i = 0; i < inventoryUI.Length; i++)
        {
            inventoryUI[i].SetImage();
        }
    }

    public void OrderExitButtonClick()
    {
        orderPanel.SetActive(false);
    }
}
