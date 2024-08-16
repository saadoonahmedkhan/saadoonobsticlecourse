using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementObstacle : MonoBehaviour
{
    [SerializeField]
    private  float MoveSpeed = 5f;
    [SerializeField]
    private float xValue, yValue;
    private float zValue;
    [SerializeField]
    private Vector3 boundary1;
    [SerializeField]
    private Vector3 tempPos;
 
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        tempPos = transform.position;
        tempPos.z *= -1;
        if(tempPos.z <0)
        {
            tempPos.z--;
            tempPos.z *= Time.deltaTime * MoveSpeed;
            transform.position = tempPos;
        }
        if(tempPos.z>0)
        {
            tempPos.z++;
            tempPos.z *=Time.deltaTime*MoveSpeed;
            transform.position = tempPos;
        }
    }

}
