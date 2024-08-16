using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droper1 : MonoBehaviour
{
    [SerializeField]
    private float waitTime;
     
    private MeshRenderer meshRenderer;
    Rigidbody rigidBody;
    void Start()
    {
        meshRenderer =GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity= false;
    }
    void _Random()
    {
        float random = Random.value;
        float time = Time.time;

        if(random<10)
        {
            time = random;
            waitTime = time;
            if (Time.time > waitTime)
            {
                meshRenderer.enabled = true;
                rigidBody.useGravity = true;
            }
        }
       
}
    void Update()
    {
        _Random();
    }
}
