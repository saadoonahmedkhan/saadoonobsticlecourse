using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droper : MonoBehaviour
{
    [SerializeField]
    private float waitTime = 3f;
    private MeshRenderer meshRenderer;
    Rigidbody rigidBody;
    void Start()
    {
        meshRenderer =GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity= false;
    }
    void Update()
    {
        if(Time.time>waitTime)
        {
            meshRenderer.enabled = true;
            rigidBody.useGravity = true; 
        }
    }
}
