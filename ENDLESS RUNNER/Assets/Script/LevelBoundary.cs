using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float leftSide = -12f;
    public static float rightSide= 12f;
    public float internalleft;
    public float internalright;

    // Update is called once per frame
    void Update()
    {
        internalleft = leftSide;
        internalright = rightSide;
    }
}
