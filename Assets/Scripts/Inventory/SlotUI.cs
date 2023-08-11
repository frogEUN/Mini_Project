using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotUI : MonoBehaviour, IPointerClickHandler
{
    private Fruit fruit;
    private Slot parentSlot;

    public void Init(Fruit _fruit, Slot slot)
    {
        fruit = _fruit;
        this.GetComponent<Image>().sprite = fruit.fruitImage;
        parentSlot = slot;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Destroy(this.gameObject);
        InventoryManager.instance.fruitsInInventory[parentSlot.slotIndex] = null;
    }
}
