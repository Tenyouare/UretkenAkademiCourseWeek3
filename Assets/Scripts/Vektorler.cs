using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vektorler : MonoBehaviour
{
    Vector2 vec, vec2, son;

    // Start is called before the first frame update
    void Start()
    {
        /*
        vec.x = 1.0f;
        vec.y = 1.0f;
        print(vec);
        */

        vec = new Vector2(5, 3);
        vec2 = new Vector2(5, 7);
        son = 2*vec + vec2;
        print(son);
    }


}
