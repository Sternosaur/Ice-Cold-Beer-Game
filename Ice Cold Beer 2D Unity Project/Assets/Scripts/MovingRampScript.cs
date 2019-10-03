using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRampScript : MonoBehaviour
{
    private float moveSpeed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Test hello world.");
    }

    // Update is called once per frame
    void Update()
    {
        //if the player presses up arrow, we move the square up.
        //if the player presses the down arrow, we move the square down.
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, moveSpeed, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -moveSpeed, 0);
        }

    }
}
