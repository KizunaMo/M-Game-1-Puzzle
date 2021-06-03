using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creat : MonoBehaviour
{
    float startPosX,startPosY;
    bool mouseClip;
    public GameObject puzzle;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            mouseClip = true;
       
    }

    private void FixedUpdate()
    {
        if (mouseClip)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            GameObject newPuzzle =  Instantiate(puzzle, mousePos, Quaternion.identity);
            newPuzzle.transform.SetParent(this.gameObject.transform);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;
            mouseClip = false;
        }
    }

}
