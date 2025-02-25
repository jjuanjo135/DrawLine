using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    void Update()
    {
        // cubo delantero
        Debug.DrawLine(new Vector3(-1, 0, 0), new Vector3(-2, 0, 0));
        Debug.DrawLine(new Vector3(-1, 0, 0), new Vector3(-1, 1, 0));
        Debug.DrawLine(new Vector3(-2, 0, 0), new Vector3(-2, 1, 0));
        Debug.DrawLine(new Vector3(-1, 1, 0), new Vector3(-2, 1, 0));
        // cubo trasero
        Debug.DrawLine(new Vector3(-1, 0, -1), new Vector3(-2, 0, -1));
        Debug.DrawLine(new Vector3(-1, 0, -1), new Vector3(-1, 1, -1));
        Debug.DrawLine(new Vector3(-2, 0, -1), new Vector3(-2, 1, -1));
        Debug.DrawLine(new Vector3(-1, 1, -1), new Vector3(-2, 1, -1));
        //laterales
        Debug.DrawLine(new Vector3(-1, 0, 0), new Vector3(-1, 0, -1));
        Debug.DrawLine(new Vector3(-1, 1, 0), new Vector3(-1, 1, -1));
        Debug.DrawLine(new Vector3(-2, 0, 0), new Vector3(-2, 0, -1));
        Debug.DrawLine(new Vector3(-2, 1, 0), new Vector3(-2, 1, -1));
    }
}
