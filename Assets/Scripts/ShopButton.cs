using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButton : MonoBehaviour
{
    public GameObject shopPanel;

    void Start()
    {
        shopPanel.SetActive(false);
    }

    public void ClickShopButton()
    {
        // shopButton�� ������ ��
        // shop�г��� Ų��
        
        shopPanel.SetActive(true);
        
    }
    

    public void ClickExitPanelButton()
    {
        // ExitPanelButton�� Ŭ������ ��
        // �г��� ����
        shopPanel.SetActive(false);
    }
}
