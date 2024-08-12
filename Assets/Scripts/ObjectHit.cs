using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private MeshRenderer objRenderer;
    [SerializeField]
    private Color originalcolor;
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color= Color.red;
    }
    private void OnCollisionExit(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = originalcolor;
    }

}
