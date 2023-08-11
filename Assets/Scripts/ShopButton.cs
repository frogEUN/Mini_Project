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
        // shopButton을 눌렀을 때
        // shop패널을 킨다
        
        shopPanel.SetActive(true);
        
    }
    

    public void ClickExitPanelButton()
    {
        // ExitPanelButton을 클릭했을 때
        // 패널을 끈다
        shopPanel.SetActive(false);
    }
}
