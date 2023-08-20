using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameData
{
    public static Buiding onBuilding = null;

    public static Order nowOrder = null;
    // -> 지금 플레이어가 위치해있는 건물의 order 정보 저장


    public static Fruit[] inventory = new Fruit[3];
}
