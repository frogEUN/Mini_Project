using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderMaker : MonoBehaviour
{
    public Buiding[] buildings;
    public Fruit[] fruitList;

    
    private void MakeOrder()
    {
        var rand = Random.Range(0, fruitList.Length - 1);

    }
}
