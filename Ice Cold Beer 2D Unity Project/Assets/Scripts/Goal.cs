using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Detect when the ball touches the goal, and then win the level.
/// </summary>

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Touched trigger.");
        if (collision.tag == "Player")
        {
            Debug.Log("The layer has entered the goal");
        }
    }
}
