using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField]
    private float xAngle = 0f;
    [SerializeField]
    private float yAngle = 1f;
    [SerializeField]
    private float zAngle = 0f;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(xAngle,yAngle,zAngle);
    }
}
