using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buiding : MonoBehaviour
{
    public int index;  // �ǹ��� ã�� �� �ִ� index ��
    private GameObject orderButton;

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
        orderButton = GameObject.Find("OrderButton");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            orderButton.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        orderButton.SetActive(false);
    }
}
