using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Intensity : MonoBehaviour
{
    public Light i;

    private void Update()
    {
        i.intensity = 7;
    }

}
