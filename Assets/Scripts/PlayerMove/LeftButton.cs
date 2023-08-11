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
            player.Translate(new Vector3(-moveSpeed * Time.deltaTime, 0, 0));
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
