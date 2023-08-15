using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buiding : MonoBehaviour
{
    public int index;  // �ǹ��� ã�� �� �ִ� index ��
    public GameObject orderButton;

    public Vector3 UIposition;  // orderUI�� ���� position

    private Order _order;
    public Order order
    {
        get => _order;
        set
        {
            _order = value;
            if(_order == null)
            {

            }
            else
            {

            }
        }
    }

    private void Start()
    {
        orderButton.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            orderButton.SetActive(true);
            GameData.onBuilding = this;
            GameData.nowOrder = OrderMaker.instance.orders[index];
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (GameData.nowOrder == OrderMaker.instance.orders[index])
        {
            orderButton.SetActive(false);
            GameData.nowOrder = null;
        }
        
        if (GameData.onBuilding == this)
        {
            GameData.onBuilding = null;
        }
    }
}
