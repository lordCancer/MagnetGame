using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SouthPoleCollision : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NorthPole"))
        {
            Debug.Log("You Win!");
        }
        else if (collision.gameObject.CompareTag("SouthPole"))
        {
            Debug.Log("Repel");
        }
    }
}

