using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyName : MonoBehaviour
{
    void Update()
    {
        // J
        Debug.DrawLine(new Vector2(0, 0), new Vector2(0, 1));
        Debug.DrawLine(new Vector2(0, 0), new Vector2(1, 0));
        Debug.DrawLine(new Vector2(1, 0), new Vector2(1, 2));
        Debug.DrawLine(new Vector2(0, 2), new Vector2(2, 2));
        // U
        Debug.DrawLine(new Vector2(3, 2), new Vector2(3, 0));
        Debug.DrawLine(new Vector2(3, 0), new Vector2(4, 0));
        Debug.DrawLine(new Vector2(4, 0), new Vector2(4, 2));
        // A
        Debug.DrawLine(new Vector2(5, 0), new Vector2(5, 2));
        Debug.DrawLine(new Vector2(6, 0), new Vector2(6, 2));
        Debug.DrawLine(new Vector2(5, 1), new Vector2(6, 1));
        Debug.DrawLine(new Vector2(5, 2), new Vector2(6, 2));
        // N
        Debug.DrawLine(new Vector2(7, 0), new Vector2(7, 2));
        Debug.DrawLine(new Vector2(7, 2), new Vector2(8, 0));
        Debug.DrawLine(new Vector2(8, 0), new Vector2(8, 2));
        // J
        Debug.DrawLine(new Vector2(9, 0), new Vector2(9, 1));
        Debug.DrawLine(new Vector2(9, 2), new Vector2(11, 2));
        Debug.DrawLine(new Vector2(10, 2), new Vector2(10, 0));
        Debug.DrawLine(new Vector2(9, 0), new Vector2(10, 0));
        // O
        Debug.DrawLine(new Vector2(12, 0), new Vector2(13, 0));
        Debug.DrawLine(new Vector2(12, 0), new Vector2(12, 2));
        Debug.DrawLine(new Vector2(12, 2), new Vector2(13, 2));
        Debug.DrawLine(new Vector2(13, 0), new Vector2(13, 2));
    }
}
