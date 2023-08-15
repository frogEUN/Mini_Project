using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderMaker : MonoBehaviour
{
    // 랜덤으로 주문을 만들고 그 정보를 저장

    public Buiding[] buildings;
    public Fruit[] fruitList;

    public static OrderMaker instance;

    public Order[] orders;

    public Order prefab;

    private void Start()
    {
        instance = this;
        orders = new Order[buildings.Length];
        MakeOrder();
    }

    private void MakeOrder()
    {
        var randFruit = Random.Range(0, fruitList.Length - 1);
        var randBuilding = Random.Range(0, buildings.Length - 1);
        orders[randBuilding] = Instantiate<Order>(prefab, buildings[randBuilding].UIposition, Quaternion.identity);
        orders[randBuilding].orderedFruit = fruitList[randFruit];

        Destroy(orders[randBuilding].gameObject, 10f);
    }
}
