using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    public Slot[] slots;
    public SlotUI slotUIPrefab;
    public Fruit[] fruitsInInventory = new Fruit[3];

    private void Start()
    {
        instance = this;
    }

    public void AddFruit(Fruit fruit)
    {
        for(int i = 0; i< slots.Length; i++)
        {
            if (slots[i].slotUI == null)
            {
                slots[i].slotUI = Instantiate<SlotUI>(slotUIPrefab);
                slots[i].slotUI.Init(fruit, slots[i]);
                slots[i].slotUI.transform.SetParent(slots[i].transform);
                slots[i].slotUI.transform.localPosition = Vector3.zero;

                fruitsInInventory[slots[i].slotIndex] = fruit;
                return;
            }
        }

        // ºóÄ­ÀÌ ¾øÀ» ¶§
        // code~~
        
    }
}
