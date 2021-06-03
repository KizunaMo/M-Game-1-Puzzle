using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClip : MonoBehaviour
{
    float startPosX;
    float startPosY;
    bool isBeingHeld = false;

    void Update()
    {
        if(isBeingHeld == true)
        {
            Debug.Log("1");
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY,0);
        }
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("0");
            Vector3 mousePos;
            Debug.Log("01");
            mousePos = Input.mousePosition;
            Debug.Log("02");
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            Debug.Log("03");

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            isBeingHeld = true;
        }
    }
    private void OnMouseUp()
    {
        isBeingHeld = false;
    }

}
