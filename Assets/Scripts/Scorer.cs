using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision collision)
    {
        hits++;
        if (hits == 1) Debug.Log("You have bumped into a wall " + hits + " time");
        else Debug.Log("You have bumped into a wall "+ hits+ " times");
    }
}
