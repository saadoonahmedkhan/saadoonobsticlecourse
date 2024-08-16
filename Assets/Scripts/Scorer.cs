using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision collision)
    {   if (!(collision.gameObject.tag == "Hit"|| collision.gameObject.tag == "Ground"))
        {
            hits++;
            if(hits ==6)
            {
                Destroy(gameObject);

            }
        }
    }
}
