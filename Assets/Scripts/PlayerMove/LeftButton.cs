using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeftButton : MonoBehaviour
{
    public Transform player;
    public float moveSpeed;
    private bool click = false;


    private void Update()
    {
        if (click)
        {
            player.rotation = Quaternion.Euler(new Vector3(0, 0, -90f));
            player.Translate(new Vector3(0, -moveSpeed * Time.deltaTime, 0));
            
        }
    }

    public void PointerDown()
    {
        click = true;
    }

    public void PointerUp()
    {
        click = false;
    }
}
