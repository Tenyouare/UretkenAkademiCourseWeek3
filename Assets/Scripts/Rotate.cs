using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 vec3;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(vec3);
    }
}
