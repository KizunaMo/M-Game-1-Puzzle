using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    Grid grid;
    int value;
    private void Start()
    { 
        
        grid = new Grid(9, 1, 2.65f, new Vector3(0, 0));
        grid = new Grid(10, 1, 2.65f, new Vector3(4, 4));
        grid = new Grid(11, 1, 2.65f, new Vector3(8, 8));
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            grid.SetValue(Camera.main.ScreenToWorldPoint(Input.mousePosition), 1);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(grid.GetValue(Camera.main.ScreenToWorldPoint(Input.mousePosition)));
        }
    }
}
