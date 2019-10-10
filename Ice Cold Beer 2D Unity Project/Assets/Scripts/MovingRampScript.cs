using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRampScript : MonoBehaviour
{
    private float moveSpeed = 0.05f;
    private float verticalInput;

    private Rigidbody2D rigidBody;
    //private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        //spriteRenderer = GetComponent<SpriteRenderer>();
        //spriteRenderer.color = Color.green;

        rigidBody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");
        rigidBody.velocity = new Vector2(0, verticalInput * moveSpeed);
    }
}
