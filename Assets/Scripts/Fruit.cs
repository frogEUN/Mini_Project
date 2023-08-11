using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Fruit : ScriptableObject
{
    public enum fruitName
    {
        none,
        apple,
        strawberry,
        tomato,
        banana,
        blueberry,
        grapes,
        pear,
        watermelon,
        pineapple,
        orange,
        lemon,
        pepper
    }

    public fruitName fruit;

    public Sprite fruitImage;
}
