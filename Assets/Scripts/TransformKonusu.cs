using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformKonusu : MonoBehaviour
{
    public Vector3 yon;
    void Update()
    {
       transform.Rotate(yon);
    }
}
