using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Order : MonoBehaviour
{
    public GameObject fruitImage;


    private Fruit _orderdFruit;
    public Fruit orderedFruit
    {
        get { return _orderdFruit; }
        set
        {
            _orderdFruit = value;
            fruitImage.GetComponent<SpriteRenderer>().sprite = _orderdFruit.fruitImage;
        }
    }
}
