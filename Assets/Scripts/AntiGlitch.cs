using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiGlitch : MonoBehaviour
{
    float boundX = 8.6f;
    float boundXNeg = -8.5f;
    float boundZ = 8.7366f;
    float boundZNeg = -8.548f;
    private Vector3 tempPos;
    void Update()
    {
        tempPos = transform.position;
        if(transform.position.z>boundZ)
        {
            tempPos.z = boundZ;
        }
        if (transform.position.z < boundZNeg)
        {
            tempPos.z = boundZNeg;
        }
        if (transform.position.x> boundX)
        {
            tempPos.x = boundX;
        }
        if (transform.position.x < boundXNeg)
        {
            tempPos.x = boundXNeg;
        }
        transform.position = tempPos;

    }

}
