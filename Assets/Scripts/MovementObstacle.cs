using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementObstacle : MonoBehaviour
{
    [SerializeField]
    private  float MoveSpeed = 1.2f;
    [SerializeField]
    private float xValue, NegzValue;
    private float zValue;
    private void OnCollisionEnter(Collision collision)
    {
        zValue = +5*Time.deltaTime*MoveSpeed;
        NegzValue = +5 * Time.deltaTime*MoveSpeed;
        transform.Translate(0,0,zValue);
        transform.Translate(0, 0,NegzValue);

    }

}
